using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace dflf
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=PL; Initial Catalog=Company; Integrated Security=SSPI; Connect Timeout=1000000");
            conn.Open();

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("LAST.:" + DateTime.Now + ":" + DateTime.Now.Millisecond);

            string s;
            SqlCommand com;

            string selectSQL;
            SqlDataReader myReader;

            // set transaction
            //s = "SET TRANSACTION ISOLATION LEVEL SERIALIZABLE BEGIN TRANSACTION";
            //s = "SET TRANSACTION ISOLATION LEVEL READ COMMITTED BEGIN TRANSACTION"; // default
            s = "SET TRANSACTION ISOLATION LEVEL READ COMMITTED BEGIN TRANSACTION";

            com = new SqlCommand(s, conn);
            com.ExecuteNonQuery();
            Console.WriteLine(s);


            try
            {
                selectSQL = "SELECT dname FROM department WHERE dno = 1; ";
                com = new SqlCommand(selectSQL, conn);
                myReader = com.ExecuteReader();// NB new method used here
                Console.WriteLine(selectSQL);
                myReader.Read(); // first advance the curser to the next tuple.
                string name = myReader.GetString(0);
                Console.WriteLine(name);
                myReader.Close(); // close nicely the ResultSet

                Console.WriteLine("HALT, then COMMIT");
                Console.ReadLine(); // halt, department not released yet
                System.Threading.Thread.Sleep(1000);

                selectSQL = "SELECT dname FROM department WHERE dno = 1; ";
                com = new SqlCommand(selectSQL, conn);
                myReader = com.ExecuteReader();// NB new method used here
                Console.WriteLine(selectSQL);
                myReader.Read(); // first advance the curser to the next tuple.
                name = myReader.GetString(0);
                Console.WriteLine(name);
                myReader.Close(); // close nicely the ResultSet

                //commit
                s = "COMMIT";
                //Console.WriteLine(s);
                com = new SqlCommand(s, conn);
                com.ExecuteNonQuery();
                Console.WriteLine(s);
            }
            catch (Exception exc) { Console.WriteLine("SQL Server abort (timeout): " + exc.ToString()); }
            conn.Close(); // close the connection nicely again

            Console.WriteLine("\n\nProgram halted nicely");
            s = Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BankOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            SQL sqlConn = new SQL("Bank", "local", "", "");
            string s;
            string update1;
            string update2;
            string update3;
            string update4;

            s = "SET TRANSACTION ISOLATION LEVEL READ COMMITTED BEGIN TRANSACTION";
            update1 = "UPDATE Konto SET saldo = 0 WHERE knr = 1";
            update2 = "UPDATE Konto set saldo = 100 WHERE knr = 2";

            update3 = "UPDATE Konto SET saldo = 100 WHERE knr = 1";
            update4 = "UPDATE Konto set saldo = 0 WHERE knr = 2";

            try
            {
                sqlConn.Open();

                //sqlConn.query(s);
                for (int i = 0; i < 100000; i++)
                {
                    sqlConn.exec(update1);
                    sqlConn.exec(update2);

                    sqlConn.exec(update3);
                    sqlConn.exec(update4);
                    Console.WriteLine("Antal gange programmet har loopet: " + i);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlConn.close();
            }
        }
    }
}

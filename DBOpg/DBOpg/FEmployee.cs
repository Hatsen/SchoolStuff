using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOpg
{
    class FEmployee
    {
        FDBConnection conn = new FDBConnection("", "", "", "");

        public void Put(EEmployee e)
        {
            try
            {
                conn.Open();
                conn.Exec("INSERT INTO Employee VALUES('" + e.GetSSN + "', '" + e.GetName + "', " + e.GetDno + ")");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void Get(string SSN)
        {
            try
            {
                conn.Open();
                conn.Exec("SELECT * FROM Employee WHERE SSN = '" + SSN + "'");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

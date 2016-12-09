using System;
using System.Collections.Generic;

namespace ArkitekturOpg2
{
    class CMEF
    {
        static void Main()
        {
            CActioner ac = new CActioner();

            Console.WriteLine("Angiv først no, så return, derefter navn.");
            int no = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            ac.createCustomer(no, name);

            no = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();

            ac.createCustomer(no, name);

            ECustomer c = ac.ReadCustomer(999);
            Console.WriteLine(c.getName());
        }
    }
    class CActioner
    {
        private MBroker bkr = MBroker.getInstance();

        public void createCustomer(long no, string name)
        {
            ECustomer cust = new ECustomer(no, name);
            bkr.sendCustomerToDBUpdater(cust);
        }

        public ECustomer ReadCustomer(long no)
        {
            return bkr.FindCustomer(no);
        }
    }
    class ECustomer
    {
        private long cno;
        private string cname;

        public ECustomer(long no, string name)
        {
            cno = no;
            cname = name;
        }
        public long getNo() { return cno; }
        public string getName() { return cname; }
    }

    class MBroker
    { // a singelton
        FUpdater upd = new FUpdater();
        List<ECustomer> cc = new List<ECustomer>();
        private static MBroker inst = new MBroker();
        public static MBroker getInstance() { return inst; }
        public void sendCustomerToDBUpdater(ECustomer c)
        {
            cc.Add(c);
            upd.saveCustomer(c);
        }

        public ECustomer FindCustomer(long no)
        {
            foreach (ECustomer c in cc)
            {
                if (c.getNo() == no)
                    return c;
                return new ECustomer(0, "Kage");
            }
        }
    }
    class FUpdater
    {
        public void saveCustomer(ECustomer c)
        {
            string SQL = "INSERT INTO Customer VALUES (" + c.getNo() + ",'" + c.getName() + "');";
            //conn.execute.update(s);
            Console.WriteLine(SQL);
        }
    }


}
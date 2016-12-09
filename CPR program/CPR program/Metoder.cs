using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPR_program
{
    class Metoder
    {
        public static bool CPRValidering(string CPR)
        {
            int a, c;
            string Bindestreg = "";
            bool Checking = true;

            if (CPR.Length > 11)
            {
                Checking = false;
            }

            try
            {
                a = Convert.ToInt32(CPR.Substring(0, 6));
                Bindestreg = CPR.Substring(6, 1);
                c = Convert.ToInt32(CPR.Substring(7, 4));
            }

            catch
            {
                Checking = false;
            }

            //Hvis CPR nummeret mangler en bindestreg, melder programmet fejl.
            if (Bindestreg != "-")
            {
                Checking = false;
            }

            return Checking;
        }

        public static int CheckDato(string CPR)
        {
            //Lige nu, antager programmet at alle personer er født i et interval af 1900
            int Dato = 0;
            int ResultDato = 0;

            Dato = Convert.ToInt32(CPR.Substring(4, 2)) + 1900;
            ResultDato = 2012 - Dato;

            return ResultDato;
        }

        public static string CheckKoen(string CPR)
        {
            int Koen;
            string ResultKoen;

            Koen = Convert.ToInt32(CPR.Substring(10, 1));

            if (Koen % 2 == 0)
            {
                ResultKoen = "kvinde";
            }
            else
                ResultKoen = "mand";

            return ResultKoen;
        }
    }
}

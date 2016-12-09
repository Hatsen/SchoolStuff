//Program der tester arv, polymorfi
//Per Larsen, Datamatikeruddannelsen i Vejle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class KontoArvPolyTest
{
    public static void Main(String[] args)
    {
        double total = 0;
        Konto[] konti = new Konto[6];

        konti[0] = new CheckKonto(10000);
        konti[1] = new PensionKonto(50000, 1);
        konti[2] = new PensionKonto(10000, 2);
        konti[3] = new CheckKonto(10000);
        konti[4] = new PensionKonto(23111, 1);
        konti[5] = new CheckKonto(20000);
        for (int i = 0; i < 6; i++)
            konti[i].printKonto();
        Console.WriteLine("saldo konto nr.3 " + konti[3].getSaldo());

        //Lægger saldoerne sammen
        for (int i = 0; i < 6; i++)
        {
            total += konti[i].getSaldo();
        }
        Console.WriteLine("Saldoerne lagt sammen giver os: {0}", total);

        var hoejesteTal = konti.Max(s => s.getSaldo());
        Console.WriteLine(hoejesteTal);
    }
}

public abstract class Konto
{
    private double saldo;

    public Konto(double initialSaldo)
    {
        saldo = initialSaldo;
    }

    public virtual void setInd(double belob)
    {
        saldo = saldo + belob;
    }

    public virtual void haev(double belob)
    {
        saldo = saldo - belob;
    }

    public double getSaldo()
    {
        return saldo;
    }

    public abstract void printKonto();

}

public class CheckKonto : Konto
{
    private int transAntal;

    public CheckKonto(double initialSaldo)
        : base(initialSaldo)
    {
        transAntal = 0;
    }

    public override void setInd(double belob)
    {
        transAntal++;
        base.setInd(belob);
    }

    public override void haev(double belob)
    {
        transAntal++;
        base.haev(belob);
    }

    public int getTransAntal()
    {
        return transAntal;

    }

    public override void printKonto()
    {
        Console.WriteLine("saldo = " + this.getSaldo() + " TransAntal = " + transAntal);
    }

    /*public String toString()
    {
        return "balance = "+this.getBalance()+ " TransactionCount = "+transactionCount;
    }
    */
}

public class PensionKonto : Konto
{
    private int code;

    public PensionKonto(double initialSaldo, int initCode)
        : base(initialSaldo)
    {
        code = initCode;
    }

    public override void printKonto()
    {
        Console.WriteLine("saldo = " + this.getSaldo() + " opsparingskode = " + code);
    }

    /*public String toString()
    {
        return "balance = "+this.getBalance()+ " pensionskode = "+code;
    }
    */
}


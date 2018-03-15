using System;
using System.Xml.Schema;

namespace InterfaceLearning
{
    public interface ITransactions
    {
        //interface members
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }
        
        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
        }

        public double getAmount()
        {
            return amount;
        }
    }
}
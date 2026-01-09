using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EventDelegateDemo
{
    interface IBank
    {
        bool OpenAccount(string details);
        List<string> GenStatement();
    }
    interface RBI
    {

    }
    class HDFC : IBank
    {
        public delegate void Transaction(int actNo, string date, int amount);
        public event Transaction Debit;
        public event Transaction Credit;
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAccount(string details)
        {
            throw new NotImplementedException();
        }
    }
    class Axis : IBank
    {
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAccount(string details)
        {
            throw new NotImplementedException();
        }
    }
    class HDFCJalandhar: HDFC
    {

    }
    public class EventDemo
    {
        public static void EventDemoMain()
        {
            HDFCJalandhar hdfcJal = new HDFCJalandhar();
            hdfcJal.Credit += HdfcJal_Credit;
        }

        private static void HdfcJal_Credit(int actNo, string date, int amount)
        {
            throw new NotImplementedException();
        }
    }
}

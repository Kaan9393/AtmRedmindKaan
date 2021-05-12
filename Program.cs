using System;
using System.Collections.Generic;
using System.Linq;

namespace AtmRedmindKaan
{
    public class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM()
            {
                ThousandBill = 2,
                FivehundredBill = 3,
                OnehundredBill = 5
            };

            int[] WithdrawArray = new int[] { 1500, 700, 400, 1100, 1000, 700, 300 };

            for (int i = 0; i < WithdrawArray.Length; i++)
            {
                atm.AtmCalculate(WithdrawArray[i]);
            }
        }
    }
}





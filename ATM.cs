using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmRedmindKaan
{
    public class ATM
    {
        public int ThousandBill { get; set; }
        public int FivehundredBill { get; set; }
        public int OnehundredBill { get; set; }
        public int RemainingTotalAmount => (ThousandBill * 1000) + (FivehundredBill * 500) + (OnehundredBill * 100);



        public bool AtmCalculate(int amount)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Amount to Withdraw {amount}");
            Console.WriteLine($"Remaining blance in account {RemainingTotalAmount}");
            Console.WriteLine($"Remaining Thousandbills [{ThousandBill}x]");
            Console.WriteLine($"Remaining Fivehundredbills [{FivehundredBill}x]");
            Console.WriteLine($"Remaining Onehundredbills [{OnehundredBill}x]\n\n");

            int UsedThousandbill = 0;
            int UsedFiveHundredBill = 0;
            int UsedOneHundredBill = 0;


            if (RemainingTotalAmount == 0 || RemainingTotalAmount < amount)
            {
                Console.WriteLine("Not enough balance in account");
                return false;
            }
            //amount != 0 && RemainingTotalAmount != 0
            while (true)
            {
                if (amount >= 1000 && ThousandBill != 0)
                {
                    amount -= 1000;
                    UsedThousandbill++;
                    ThousandBill --;
                    Console.WriteLine($"Tried to withdrawal: 1x - 1000\nWithdrawal left: {amount}");

                }

                else if (amount >= 500 && FivehundredBill != 0)
                {
                    amount -= 500;
                    UsedFiveHundredBill++;
                    FivehundredBill --;
                    Console.WriteLine($"Tried to withdrawal: 1x - 500\nWithdrawal left: {amount}");
                }


                else if (amount >= 100 && OnehundredBill != 0)
                {
                    amount -= 100;
                    UsedOneHundredBill++;
                    OnehundredBill--;
                    Console.WriteLine($"Tried to withdrawal: 1x - 100\nWithdrawal left: {amount}");

                }
                else if (amount == 0)
                {
                    Console.WriteLine("Withdrawal successfully done");
                    return true;
                }

                else
                {
                    ThousandBill += UsedThousandbill;
                    FivehundredBill += UsedFiveHundredBill;
                    OnehundredBill += UsedOneHundredBill;
                    Console.WriteLine("\nWithdraw failed\n*Reset of amounts 'tried withdrawals' is completed!");
                    return false;
                }

            }
            Console.WriteLine("-----------------------------------------");

            return true;
        }
    }
}

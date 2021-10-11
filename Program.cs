using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMoney showMoney = ShowDollars;
            Console.WriteLine(showMoney(1000));

            showMoney = ShowEuros;
            Console.WriteLine(showMoney(1000));

            Console.ReadLine();


        }

        public delegate string ShowMoney(int money);

        public static string ShowEuros (int money)
        {
           return  "vous avez " + money + " €";
        }

        public static string ShowDollars(int money)
        {
           return "vous avez " + money + " $";
        }

    }
}

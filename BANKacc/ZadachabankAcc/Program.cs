using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachabankAcc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi danni");
            BankAcc obj = new BankAcc(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), decimal.Parse(Console.ReadLine()));
            Console.WriteLine("insertprice");
            decimal insertprice = decimal.Parse(Console.ReadLine());
            obj.Inserttp(insertprice);
            Console.WriteLine("Vuvedi danni");
            BankAcc obj2 = new BankAcc(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), decimal.Parse(Console.ReadLine()));
            obj2.Removep(45);
            List<BankAcc> list = new List<BankAcc>() { obj, obj2};
            foreach (var item in list)
            {
                item.izhod();
            }
            
        }
    }
}

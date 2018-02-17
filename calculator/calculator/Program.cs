using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej og velkommen til din lommeregner");
            Console.WriteLine("skriv et regnestykke og så klarer jeg den for dig!");
            var toCalc = Console.ReadLine();
            DataTable dt = new DataTable();
            var res = dt.Compute(toCalc, "");

            Console.WriteLine(res);
            //var splitToCalc = toCalc.ToCharArray();
            //var calcOperator = splitToCalc[1].ToString();
            //var firstNo = Int32.Parse(splitToCalc[0].ToString());
            //var secondNo = Int32.Parse(splitToCalc[2].ToString());
            //switch (calcOperator)
            //{
            //    case "+":
            //        Console.WriteLine(firstNo + secondNo);
            //        break;
            //    default:
            //        Console.WriteLine("wait what?");
            //        break;
            //}

            Console.ReadKey();
        }


    }
}

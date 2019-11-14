using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            var db = new OOPCSEntities();
            var list = db.Expenditures.ToArray();
            for(int i=0; i<list.Length; i++)
            {
                Console.WriteLine(list[i].id + " " + list[i].Note + " " + list[i].Price);
                sum+=list[i].Price;
            }
            Console.WriteLine("Tong tien da xai la:");
            Console.WriteLine(sum);
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //restaurantEntities db = new restaurantEntities();
            var db = new restaurantEntities();
            //var list = db.Breakfasts.ToList();
            //Console.WriteLine("having: "+ list.Count);
            //list.ForEach(i => Console.WriteLine(i.name + " price " + i.price));
            var list = db.Breakfasts.ToArray();
            Console.WriteLine("Having: " + list.Length);
            for (int i = 0; i < list.Length;i++ )
            {
                Console.WriteLine(list[i].name + " Price: " + list[i].price);
            }
            var NewList = new Breakfast();
            NewList.name = "Hot vit lon";
            NewList.price = 10000;
            db.Breakfasts.Add(NewList);
            db.SaveChanges();

                db.Dispose();
        }

    }
}

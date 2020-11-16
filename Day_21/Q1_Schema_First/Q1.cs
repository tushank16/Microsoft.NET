using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Q1
    {
        //Q1.Using entity frame work complete schema first approach and perform insert, delete, update
        static void Main(string[] args)
        {
            DemodataEntities db = new DemodataEntities();
            var result = db.Products.ToList<Product>();
            //Console.WriteLine(db.Products); //for printing the Querry
            foreach (var r in result)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", r.Id, r.Name, r.Price, r.Qty);

            //counting the instances
            var resultcount = db.Products.Count<Product>();
            Console.WriteLine( " Total no of entries : " + resultcount);

            Insert();
            Delete(3002);
            Update(1008, "LED");
        }

        public static void Insert()
        {
            DemodataEntities db = new DemodataEntities();
            Product product = new Product
            {
                Name = "Processor",
                Price = 27000,
                Qty = 5
            };
            db.Products.Add(product);        
            db.SaveChanges();
            Console.WriteLine("\nProduct Table after Insert");
            var result = db.Products.ToList<Product>();
            foreach (var r in result)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", r.Id, r.Name, r.Price, r.Qty);

        }

        public static void Update(int id, string name)
        {
            DemodataEntities db = new DemodataEntities();
            Product product = db.Products.Find(id);
            product.Name = name;
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            Console.WriteLine("\nProduct Table after Update");
            var result = db.Products.ToList<Product>();
            foreach (var r in result)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", r.Id, r.Name, r.Price, r.Qty);
        }

        public static void Delete(int id)
        {
            DemodataEntities db = new DemodataEntities();
            Product p1 = db.Products.Find(id);
            db.Products.Remove(p1);
            db.SaveChanges();
            Console.WriteLine("\nProduct Table after Delete");
            var result = db.Products.ToList<Product>();
            foreach (var r in result)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", r.Id, r.Name, r.Price, r.Qty);

        }
    }
}

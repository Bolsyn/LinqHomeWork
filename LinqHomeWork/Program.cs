using LinqHomeWork.Blanks;
using LinqHomeWork.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //var hddFirst = new Hdd
            //{
            //    Price = 40000,
            //    IsHit = true,
            //    Creater = "Toshiba",
            //    Interface = "SATA III",
            //    Volume = 10000,
            //    Buffer = 64,
            //    SpindleSpeed = 5400
            //};
            //var hddSecond = new Hdd
            //{
            //    Price = 20000,
            //    IsHit = false,
            //    Creater = "Seagate",
            //    Interface = "SATA II",
            //    Volume = 2000,
            //    Buffer = 32,
            //    SpindleSpeed = 7400
            //};
            //var hddThird = new Hdd
            //{
            //    Price = 35000,
            //    IsHit = false,
            //    Creater = "Corsair",
            //    Interface = "SATA II",
            //    Volume = 4000,
            //    Buffer = 128,
            //    SpindleSpeed = 7400
            //};



            //using (var context = new LibraryContext())
            //{
            //    context.AddRange(hddFirst,hddSecond,hddThird);
            //    context.SaveChanges();

            //}
            Console.WriteLine("Выберите вариант сортировки");
            Console.WriteLine("1 - По интерфейсу");
            Console.WriteLine("2 - По цене");
            Console.WriteLine("3 - По объему");
            Console.WriteLine("4 - По скорости");
            Console.WriteLine("5 - Популярное");
            Console.WriteLine("6 - По изготовителю");
            string sortRead = Console.ReadLine();
            int.TryParse(sortRead,out int sort);

            using (var context = new LibraryContext())
            {
                var perPage = 30;
                var currentPage = 1;

                var hdds = context.Hdds
                    .Skip((currentPage - 1) * perPage)
                    .Take(perPage);

                if (sort == 1)
                {
                    hdds.OrderBy(hdd => hdd.Interface);
                }
                if (sort == 2)
                {
                    hdds.OrderBy(hdd => hdd.Price);
                }
                if (sort == 3)
                {
                    hdds.OrderBy(hdd => hdd.Volume);
                }
                if (sort == 4)
                {
                    hdds.OrderBy(hdd => hdd.SpindleSpeed);
                }
                if (sort == 5)
                {
                    hdds.OrderBy(hdd => hdd.IsHit.Equals(true));
                }
                if (sort == 6)
                {
                    hdds.OrderBy(hdd => hdd.Creater);
                }

                var result = hdds.ToList();
            }
        }
    }
}

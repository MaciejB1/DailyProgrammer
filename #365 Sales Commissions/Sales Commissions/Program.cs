using System;
using System.Collections.Generic;

namespace Sales_Commissions
{
    class Program
    {
        public class Worker
        {
            //Class variables
            public string nameOfWorker;

            //Class constructors
            public Worker()
            {
                nameOfWorker = "Deafult";
            }

            public Worker(string name)
            {
                nameOfWorker = name;
            }         
        }

        public class Revenue : Worker
        {
            public int teaRevenue;
            public int coffeeRevenue;
            public int waterRevenue;
            public int milkRevenue;


            //Class constructors
            public Revenue()
            {
                teaRevenue = 0;
                coffeeRevenue = 0;
                waterRevenue = 0;
                milkRevenue = 0;
            }

            public Revenue(int _teaRevenue, int _coffeeRevenue, int _waterRevenue, int _milkRevenue)
            {
                teaRevenue = _teaRevenue;
                coffeeRevenue = _coffeeRevenue;
                waterRevenue = _waterRevenue;
                milkRevenue = _milkRevenue;
            }
        }

        public class Expenses : Revenue
        {
            public int teaExpenses;
            public int coffeeExpenses;
            public int waterExpenses;
            public int milkExpenses;


            //Class constructors
            public Expenses()
            {
                teaExpenses = 0;
                coffeeExpenses = 0;
                waterExpenses = 0;
                milkExpenses = 0;
            }

            public Expenses(int _teaExpenses, int _coffeeExpenses, int _waterExpenses, int _milkExpenses)
            {
                teaExpenses = _teaExpenses;
                coffeeExpenses = _coffeeExpenses;
                waterExpenses = _waterExpenses;
                milkExpenses = _milkExpenses;
            }
            
            //Class functions
            public int CalculateCommission()
            {
                double result = 0;

                if ((teaRevenue - teaExpenses) >= 0)
                    result += (teaRevenue - teaExpenses);
                if ((coffeeRevenue - coffeeExpenses) >= 0)
                    result += (coffeeRevenue - coffeeExpenses);
                if ((waterRevenue - waterExpenses) >= 0)
                    result += (waterRevenue - waterExpenses);
                if ((milkRevenue - milkExpenses) >= 0)
                    result += (milkRevenue - milkExpenses);

                result *= 0.062;

                return Convert.ToInt32(result);
            }

            public Expenses NewEmplo(Expenses emplo)
            {
                Console.Write("Give name: ");
                emplo.nameOfWorker = Console.ReadLine();
                Console.Write("Give teaRevenue: ");
                emplo.teaRevenue = Convert.ToInt32 (Console.ReadLine());
                Console.Write("Give coffeeRevenue: ");
                emplo.coffeeRevenue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give waterRevenue: ");
                emplo.waterRevenue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give milkRevenue: ");
                emplo.milkRevenue = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give teaExpenses: ");
                emplo.teaExpenses = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give coffeeExpenses: ");
                emplo.coffeeExpenses = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give waterExpenses: ");
                emplo.waterExpenses = Convert.ToInt32(Console.ReadLine());
                Console.Write("Give milkExpenses: ");
                emplo.milkExpenses = Convert.ToInt32(Console.ReadLine());

                return emplo;
            }

        }

        static void Main(string[] args)
        {
            List<Expenses> workers = new List<Expenses>();
            Console.Write("The amount of eployees: ");
            int amount;                                     //The amount of workers
            amount = Convert.ToInt32 (Console.ReadLine());

            List<int> commisions = new List<int>();


            for (int i = 0; i<amount ;i++)              //Add workers
            {
                Expenses emplo = new Expenses();
                emplo.NewEmplo(emplo);
                workers.Add(emplo);
            }

            for (int i = 0; i < amount; i++)           //Commission
            {
                int result;
                result = workers[i].CalculateCommission();
                commisions.Add(result);
            }



            for (int i = 0; i < 2; i++)                //Print matrices with commissions
            {
                Console.WriteLine();
                for (int j = 0; j < amount; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(workers[j].nameOfWorker + "   ");
                    }
                    else
                        Console.Write(commisions[j] + "          ");
                }
            }

            Console.ReadKey();
        }
    }
}

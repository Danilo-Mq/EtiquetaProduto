﻿using System.Collections.Generic;
using Seção9_Exercicio_4.Entities;

namespace /*Insira aqui o nome do seu namespace*/
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i) ? ");
                char Product = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = int.Parse(Console.ReadLine());
               
                if (Product == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = int.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                } else if(Product == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }       
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.ToString());
            }




        }
    }
}

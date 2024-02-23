using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    class Products
    {
        public string pname;
        public float price;
        public int quantity;
        public float bill;
    }
    internal class Program
    {
        static Products takeInput(int x)
        {
            Products product = new Products();
            Console.Write("Enter The {0} Product: ", x);
            product.pname = Console.ReadLine();
            Console.Write("Enter its Price: ");
            product.price = float.Parse(Console.ReadLine());
            Console.Write("Enter its Quantity: ");
            product.quantity = int.Parse(Console.ReadLine()); 
            return product;
        }
        static void calculateBill(Products[] product, int usercount)
        {
            for (int i = 0; i < usercount; i++)
            {
                product[i].bill =(float) (product[i].quantity * product[i].price);
            }
        }
         
        static void Main(string[] args)
        {
            bool valid = true;
            int userCount = 0;
            Products[] product = new Products[100];
            while (valid)
            {
                Console.Clear();
                Console.WriteLine("Store Management System");
                Console.WriteLine("\n\n\n1. Add Product");
                Console.WriteLine("2. Show Products Detail ");
                Console.WriteLine("3. Calculate Bill ");
                Console.WriteLine("4. Exit ");
                Console.Write("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    int x = 1;
                    product[userCount] = takeInput(x);
                    x++;
                    userCount++;
                }
                else if (choice == 2)
                {
                    calculateBill(product,userCount);
                    Console.WriteLine("Items\t\t\tQuantity\t\t\tFSCMarks\t\t\tPrice Per Unit\t\t\t Total Price ");
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(product[i].pname + "\t\t\t" + product[i].quantity + "\t\t\t" + product[i].price + "\t\t\t" + product[i].bill);
                    }
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    float bill = 0;
                    for (int i = 0; i < userCount; i++)
                    {
                        Console.WriteLine(product[i].pname + "\t\t\t" + product[i].quantity + "\t\t\t" + product[i].price + "\t\t\t" + product[i].bill);
                        bill = (float)(bill + product[i].bill);
                    }

                    Console.WriteLine("\n\n\n \t\t\t\t\t\t\t\t\t\t\t Total Bill: {0}",bill);

                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    valid = false;
                }


            }
        }
}

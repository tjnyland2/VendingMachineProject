using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuctures
{
    internal class Program
    {
        struct VendingMachine //Creates a structure called teams
        {
            public string name; //Name of product
            public int ID; //ProductID
            public double price;//Price of the product

        }

        static void Main(string[] args) //Main
        {
            bool online = true;
            VendingMachine[] table = new VendingMachine[10]; //Creates an array with all the values from the struct
            for (int i = 0; i<10; i++)
            {
                //Mars Bar
                table[0].name = "Mars Bar";
                table[0].ID = 01;
                table[0].price = 1.20;
                // Walkers Crisps
                table[1].name = "Walkers Crisps";
                table[1].ID = 02;
                table[1].price = 0.80;
                //Hula hoop crisps
                table[2].name = "Hula hoop crisps";
                table[2].ID = 03;
                table[2].price = 1.00;
                //Double Decker
                table[3].name = "Double Decker";
                table[3].ID = 04;
                table[3].price = 1.50;
                //doritos
                table[4].name = "Doritos";
                table[4].ID = 05;
                table[4].price = 1.99;
                //doritos
                table[5].name = "cheetos";
                table[5].ID = 06;
                table[5].price = 1.00;



            }
            while (online == true)
            {
                int choice = 0;
                Console.WriteLine("Welcome to the vending machine.");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("[1] Insert Coins: ");
                Console.WriteLine("[2] Select your product ");
                Console.WriteLine("[3] Exit ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) //Switch statment for option values
                {
                    case 1: //If enter option 1
                        Console.WriteLine("Please insert your coins:");
                        Console.WriteLine("Coins sucessfully entererd");
                        Console.WriteLine("Would you like to go back to main menu? (y/n");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            Console.WriteLine("Returning to menu....");
                            Console.WriteLine("\n");
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Exiting the program");
                            online = false;
                        }
                        else
                        {
                            Console.WriteLine("Invaid input | Returning to main menu");
                            Console.WriteLine("\n");
                            return;
                        } 
                        break;
                    case 2:
                        Console.WriteLine("You have choosen to View all the teams!");
                        ViewMachine(ref table);//Calls the CreateLeauge method and passes table array
                        break;
                    case 3:
                        Console.WriteLine("Enter ADMIN password to add items to the vending machine:");
                        string password = Console.ReadLine();
                        if (password == "Password123")
                        {
                            AddItem(ref table);//Calls the AddItem method and passes table array
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password. Not allowed in");
                        }
                        AddItem(ref table);//Calls the AddItem method and passes table array
                        break;

                    default:
                        Console.WriteLine("An error has occured");
                        break;
                }
                Console.ReadLine();
            }
        }
        static void AddItem(ref VendingMachine[] table)
        {
            for (int i = 10; i < 6; i++)
            {
                Console.WriteLine("Please enter product name: ");
                table[i].name = Console.ReadLine();
                Console.WriteLine("Enter Product ID: ");
                table[i].ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the price of product: ");
                table[i].price = double.Parse(Console.ReadLine());
            }



        }
        static void ViewMachine(ref VendingMachine[] table)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Name:" + table[i].name + "\t ");
                Console.Write("ID: " + table[i].ID + "\t ");
                Console.Write("Price:" + table[i].price + "\t ");
                Console.Write("\n");


            }



        }

    }
}
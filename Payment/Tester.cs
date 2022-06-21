using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Tester //:UPIpayment
    {
        static void Main(string[] args)
        { 
            UPIpayment uPIpayment = new UPIpayment();   
            CardPayment cardPayment = new CardPayment();
            
            int balance = 100000;
            Console.WriteLine("Available balance is : " + balance);



            //Console.WriteLine("Enter amount to be transfer : ");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //if (uPIpayment.debit(amount))
            //{

            //    Console.WriteLine("Payment succesful!!!");
            //}
            //else { Console.WriteLine("Payment Declined!!! Try lower amount"); }














            Console.WriteLine("select Payment Method: ");
            Console.WriteLine("1:UPI   2:Credit/Debit Card  3:Net Banking ");


            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter Upi Address: ");
                        string upiAdd = Console.ReadLine();
                        Console.WriteLine("Enter Amount to be transfer: ");
                        int amt1 = Convert.ToInt32(Console.ReadLine());
                        if (uPIpayment.debit(amt1))
                        {
                            int rem = balance - amt1;
                            Console.WriteLine("Payment succesful!!!");
                            Console.WriteLine("Available balance is: " + rem);
                        }
                        else { Console.WriteLine("Payment Declined!!! Try lower amount"); }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter Card Number and Cvv: ");
                        string cardNo = Console.ReadLine();
                        Console.WriteLine("Enter Amount to be transfer: ");
                        int amt1 = Convert.ToInt32(Console.ReadLine());
                        if (cardPayment.debit(amt1))
                        {
                            Console.WriteLine("Payment succesful!!!");
                        }
                        else { Console.WriteLine("Payment Declined!!! Try lower amount"); }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter valid Option!!");
                        break;
                    }
            }
        }
    }
}

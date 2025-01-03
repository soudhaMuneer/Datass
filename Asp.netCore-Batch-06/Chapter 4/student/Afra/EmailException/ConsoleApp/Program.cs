// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool chance = false;
            do
            {
                try
                { 
                    Console.WriteLine("enter your email");
                    string email = Console.ReadLine();
                    if (IsValidEmail(email))
                    {
                        Console.WriteLine("Email is valid.");
                        chance= true;
                        break;
                    }
                
                    else
                    {
                       
                        throw new emailExecption(email);
                        Console.WriteLine("Email is not valid.");
                    }
                }

                catch (Exception emailexp)
                {
                    Console.WriteLine(emailexp.Message);
                }
             
            } while(chance=true);
           
                
        
        }

        static bool IsValidEmail(string email)
        {
            // Regular expression for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
    }




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int onlyNumPin = 0;
            int onlyNumLogin = 0;

            while (onlyNumPin == 0)
            {
               

                Console.WriteLine("Create a pincode for your program!");

                string setPincode = Console.ReadLine();
                Console.Clear();

                int pincode = 0;

                bool a = int.TryParse(setPincode, out pincode);

                if (a)
                {
                    onlyNumPin++;
                    while (onlyNumLogin == 0) 
                    { 
                        Console.WriteLine("Awesome! Now, please enter your pin code to log in");

                        string input = Console.ReadLine();
                        Console.Clear();

                        int compare = 0;

                        bool b = int.TryParse(input, out compare);

                        if (b)
                        {
                            onlyNumLogin++;
                            if (pincode == compare)
                            {
                                Console.WriteLine("Welcome! Please enter your name to fully set up your profile");

                                string name = Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("Noted! Welcome " + name + " to the incredibly unique, special and thrilling SafeShop - 'keep your transactions safe'");
                                Console.ReadLine();
                            }
                            else
                            {

                                Console.WriteLine("WRONG PINCODE. YOU ARE BEING SENT OUT OF THE APPLICATION");

                                Console.ReadLine();
                            }

                        }
                        else
                        {
                        Console.WriteLine("Only numbers, please");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Only numbers, please");
                }


            }
        }
    }
}

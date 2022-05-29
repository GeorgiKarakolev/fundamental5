using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 9.80;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 10.46;
                }
                if (countOfPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }

            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 15.60;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 16;
                }
                if (countOfPeople >= 100)
                {
                    totalPrice -= totalPrice / countOfPeople * 10;
                }

            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = countOfPeople * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = countOfPeople * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = countOfPeople * 22.50;
                }
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }

            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

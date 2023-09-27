using System;
namespace v._39
{
    public class utility
    {

        //Metod ålder.
        public static int GetAge()
        {
            Console.WriteLine("Please Enter Your age");
            int age = Console.ReadLine();

            return age;
        }

        //metod plats.
        public static string GetSeat()
        {
            string place = Console.ReadLine();
            if (place != "Seated" && place != "Standig")
            {

                Console.WriteLine("Please Enter Seated or Standing");
            }

            return place;
        }

        // Metod summa. 
        public static decimal GetCost()
        {
            string cost = Console.ReadLine();
            if (place == "Seated")
            {

                if (age > 11)
                {
                    cost = 50;
                }

                else if (11 <=age && <65)
                {
                    cost = 170;
                }

                else (64 < age);
                {
                    cost = 100;
                }

            }
            if (place == "Standing") ;
            {

                if (age > 11)
                {
                    cost = 25;
                }

                else if (11 <= age && <65)
                {
                    cost = 110;
                }

                else (64 < age);
                {
                    cost = 60;
                }

            }



            return cost;
        }

        // metod skatt 
        public static string GetTax()
        {

            string tax = (1 - (1 / 1.06)) * cost;

            return tax;
        }

        public static int TicketNumber()
        {
            Random Random = new();
            int ticket = Random.Next(1, 8000);

            return ticket;

        }
    }
}




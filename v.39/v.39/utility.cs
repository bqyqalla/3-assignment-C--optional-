using System;
namespace v._39
{
    public class utility
    {


        //Metod ålder.
        public static int GetAge()
        {
            Console.WriteLine("Please Enter Your age");
            int age = int.Parse(Console.ReadLine());

            return age;
        }

        //metod plats.
        public static FirstStep GetSeat()
        {
            Console.WriteLine("Seated och Standing ticket?");

            string placeInput = Console.ReadLine();


            if (Enum.TryParse(placeInput, out FirstStep place) && Enum.IsDefined(typeof(FirstStep), place))
            {
                return place;

            }

            else

            {
                Console.WriteLine("Please Enter Seated or Standing");
                return place; 
            }




        }

            
            
            
                
        

        // Metod summa. 
        public static decimal GetCost(int age, FirstStep place)
        {

            decimal cost = 0;
            if (place == FirstStep.Seated)
            {

                if (age > 11)
                {
                    cost = 50;
                }

                else if (11 <= age && age <= 65)
                {
                    cost = 170;
                }

                else if (64 < age)
                {
                    cost = 100;
                }

            }
            if (place == FirstStep.Standing)
            {

                if (age > 11)
                {
                    cost = 25;
                }

                else if (11 <= age && age <= 65)
                {
                    cost = 110;
                }

                else if (64 < age)
                {
                    cost = 60;
                }

            }



            return cost;
        }

        // metod skatt 
        public static decimal GetTax(decimal cost)
        {

            decimal tax = (decimal)(1 - (1 / 1.06)) * cost;

            return tax;
        }

        public static int TicketNumber()
        {
            Random Random = new();
            int ticket = Random.Next(1, 8000);

            return ticket;

        }

        // Optional 1.
        public static bool CheckPlaceAvailability(string placeList, int ticket)
        {
            bool avalible = placeList.Contains(ticket.ToString());

            return !avalible;





        }

        public static string AddPlace(string placeList, int ticket)
        {
            string newPlaceList = string.Join(",", placeList, ticket);

            //add Placenubmer => to placelist

            return newPlaceList;
        }



        
    }
}




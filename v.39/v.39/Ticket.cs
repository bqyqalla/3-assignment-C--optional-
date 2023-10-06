using System;
namespace v._39
{
    public class Ticket
    {

        public int Age { get; set; }
        public Enum Place { get; set; }
        public int Number { get; set; }

        public Ticket(int age, Enum place)
        {
            Age = age;
            Place = place;
            Number = TicketSalesManager.NextTicketNumber();
        }

        public decimal Price()
        {

            decimal cost = 0;
            if (Place.ToString() == FirstStep.Seated.ToString())
            {

                if (Age > 11)
                {
                    cost = 50;
                }

                else if (11 <= Age && Age <= 65)
                {
                    cost = 170;
                }

                else if (64 < Age)
                {
                    cost = 100;
                }


                if (Place.ToString() == FirstStep.Standing.ToString())
                {

                    if (Age > 11)
                    {
                        cost = 25;
                    }

                    else if (11 <= Age && Age <= 65)
                    {
                        cost = 110;
                    }

                    else if (64 < Age)
                    {
                        cost = 60;
                    }

                }
                
            }
            return cost;
        }

             public decimal Tax(decimal cost)
            {

                decimal tax = (decimal)(1 - (1 / 1.06)) * cost;

                return tax;
            }


        
    }
}


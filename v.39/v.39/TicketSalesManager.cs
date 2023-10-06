using System;
using System.Linq;
using System.Net.Sockets;

namespace v._39
{
    public class TicketSalesManager
    {
        public List<Ticket> tickets { get; set; } = new List<Ticket>();
        
        
            
        public static int NextTicketNumber()
        {
            Random Random = new();
            int ticket = Random.Next(1, 8000);

            return ticket;

        }



        public Ticket AddTicket(Ticket ticket)
        {
            ticket.Number = NextTicketNumber();
            tickets.Add(ticket);
            return ticket;
        }

        public bool RemoveTicket(Ticket ticket)
        {


            bool avalible = tickets.Find(t => t.Number == ticket.Number) is Ticket;
            if (avalible)
            {
                return false;
            }
            tickets.Remove(ticket);
            return true;


        }
        public decimal SalesTotal()
        {
            decimal total = 0;

            foreach(Ticket ticket in tickets)
            {
                total += ticket.Price();
                
            }

            return total;
            
        }


        public int AmountOfTickets()
        {
            int amount = tickets.Count();

            
            return amount;

            
        }


    } 
    
}


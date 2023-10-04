// See https://aka.ms/new-console-template for more information
using v._39;

Console.WriteLine("Hello, World!");



//Console.WriteLine("Book Your Ticket Here");

// Fråga ålder?
//int age = v._39.utility.GetAge();
// Fråga plats?
//v._39.FirstStep place = v._39.utility.Price();

// Ge pris.
//decimal cost = v._39.utility.GetCost(age, place);
// Visa skatt.
//decimal tax = v._39.utility.GetTax(cost);
// Visa Biljett.
//int ticket = v._39.utility.TicketNumber();







//Optional 1.

//string placeList = "34,1003,389,4100,4890,7233,2855";
//bool avalible = v._39.utility.CheckPlaceAvailability(placeList, ticket);


//while(!avalible)
//{
//  ticket = v._39.utility.TicketNumber();
//avalible = v._39.utility.CheckPlaceAvailability(placeList, ticket);
//}





//Svar. 
//Console.WriteLine($"Ticket Prise is {cost}kr");
//Console.WriteLine($"Taxammount: {tax}kr");
//Console.WriteLine($"Your Ticket number is:{ticket}");
//Console.WriteLine();

//Console.WriteLine("New placelist "+v._39.utility.AddPlace(placeList, ticket));


Ticket ticket = new Ticket(24, FirstStep.Seated);


Console.WriteLine(ticket.Age);
Console.WriteLine(ticket.Place);
Console.WriteLine(ticket.Price());
Console.WriteLine(ticket.Tax(ticket.Price()));



// See https://aka.ms/new-console-template for more information
using System.Linq;
using System.Text.Json;
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



TicketSalesManager salesManager = new TicketSalesManager();


salesManager.AddTicket(new Ticket(11, FirstStep.Seated));
salesManager.AddTicket(new Ticket(11, FirstStep.Seated));
salesManager.AddTicket(new Ticket(11, FirstStep.Seated));


Console.WriteLine(salesManager.SalesTotal());

string concertData = File.ReadAllText("/Users/bledonqyqalla/Desktop/coding/v.39/3-assignment-C/v.39/v.39/concert_data.json");

List <Concert> concerts = JsonSerializer.Deserialize<List<Concert>>(concertData);



//1. Return a new List<Concert> ordered by the Date value,
//going from the present date.
List<Concert> concert1 = concerts
.OrderByDescending(m => m.Date)
.ToList();

foreach (Concert concert in concert1)
{
    Console.WriteLine($"{concert.Id}, {concert.ReducedVenue}, {concert.Date}, {concert.Performer}, {concert.BeginsAt}, {concert.FullCapacitySales}");// FEEEELL återkom sen 
}
Console.WriteLine();

//2.Return a new List<Concert> with all concerts of a ReducedVenue (true).
List<Concert> concert2 = concerts
    .Where(g => g.ReducedVenue == true)
    .ToList();
foreach (Concert concert in concert2)
{
    Console.WriteLine($"{concert.Id}, {concert.ReducedVenue}, {concert.Date}, {concert.Performer}, {concert.BeginsAt}, {concert.FullCapacitySales}");// FEEEELL återkom sen 
}
Console.WriteLine();

//3.Return a new List<Concert> with all concerts during 2024.
List<Concert> concert3 = concerts
    .Where(s => s.Date.Year == 2024)
    .ToList();
foreach (Concert concert in concert3)
{
    Console.WriteLine($"{concert.Id}, {concert.ReducedVenue}, {concert.Date}, {concert.Performer}, {concert.BeginsAt}, {concert.FullCapacitySales}");// FEEEELL återkom sen 
}
Console.WriteLine();

//4. Return a new List<Concert> with the five biggest projected
//sales figures (the FullCapacitySales value).
List<Concert> concert4 = concerts
    .OrderBy(f => f.FullCapacitySales)
    .SkipLast(20)// inte hållbar ifall listan växer.. 
    .ToList();
foreach (Concert concert in concert4)
{
    Console.WriteLine($"{concert.Id}, {concert.ReducedVenue}, {concert.Date}, {concert.Performer}, {concert.BeginsAt}, {concert.FullCapacitySales}");// FEEEELL återkom sen 
}
Console.WriteLine();

//5.Return a new List<Concert> with all concerts taking place on a Friday.
//The Date (because it is of DateTime) has a property called DayOfWeek.
//There is also an enumeration called the same thing, DayOfWeek.

List<Concert> concert5 = concerts
    .Where(x => x.Date.DayOfWeek == DayOfWeek.Friday)
    .ToList();
foreach (Concert concert in concert5)
{
    Console.WriteLine($"{concert.Id}, {concert.ReducedVenue}, {concert.Date}, {concert.Performer}, {concert.BeginsAt}, {concert.FullCapacitySales}");// FEEEELL återkom sen 
}
Console.WriteLine();


// Exemptions First Step




string Numbers = ("1,2,3,4,5,6,7,k,8,9,10");

List<int> GetNumbers(string Numbers)
{
    string[] number = Numbers.Split(',');
    List<int> numb = new List<int>();
   

for(int i = 0; i < number.Length; i++)
    {
        try
        {
            numb.Add(int.Parse(number[i]));

        }
        catch (FormatException)
        {
            Console.WriteLine("Entry discarded");
        }

    }

    return numb;
}

//Console.WriteLine(Numbers);

List<int> numbers = GetNumbers(Numbers);


     List<int> numbers1 = numbers
        .OrderByDescending(x => x)
        .ToList();
foreach (int numb in numbers1)
{
    Console.WriteLine(numb);
}
Console.ReadLine();


// Third Step



//string filepath = @"aborre.txt";

WordsDTO GetFile(string filePath)
{
    string[] borreFile=  { };
    bool success;
    string fail;




    try
    {

        List<string> aborreList = new List<string>();

        List<string> aborre = aborreList
          .OrderBy(a => a)
          .ToList();

        foreach (string abor in aborre)
        {
            Console.WriteLine(abor);
        }
        Console.ReadLine();



        string textAborre = File.ReadAllText(filePath);
        borreFile = aborreList.ToArray();
        foreach (var item in textAborre.Split(","))
        {
            aborreList.Add($"{item} ");
        }
       

        success = true;
        fail = "Success";


    }


    catch (Exception)
    {
        success = false;
        fail = "File not found";
        Console.WriteLine("File not found");
       

    }


    

    return new WordsDTO(borreFile, success, fail);
}


WordsDTO borreDTO =  GetFile("/Users/bledonqyqalla/Desktop/coding/v.39/3-assignment-C/v.39/v.39/aborre.txt");

foreach(var borre in borreDTO.MyWord)
{
    Console.WriteLine(borre);
}
Console.WriteLine(borreDTO.MyBool);
Console.WriteLine(borreDTO.MyString);



//string fishdata = File.ReadAllText("/Users/bledonqyqalla/Desktop/coding/v.39/3-assignment-C/v.39/v.39/fish_data.json");
//JsonSerializer.Deserialize<List<Fishdata>>(fishdata);

//List<Fishdata> word = JsonSerializer.Deserialize<List<Fishdata>>(fishdata);

//List<Fishdata> fishdatas = new List<Fishdata>();

//List<Fishdata> fish1 = fishdatas
//    .OrderBy(f => f.Weight)
//    .ToList();
//foreach (Fishdata fish in fish1)
//{
//    Console.WriteLine(fish);
//}
//Console.ReadLine();



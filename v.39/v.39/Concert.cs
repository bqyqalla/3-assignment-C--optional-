using System;
namespace v._39
{
	public class Concert
	{
        public int Id { get; set; }
        public bool ReducedVenue { get; set; }
        public DateTime Date { get; set; }
        public string Performer { get; set; }
        public int BeginsAt { get; set; }
        public int FullCapacitySales { get; set; }

        public Concert()
		{

        }
    }
}

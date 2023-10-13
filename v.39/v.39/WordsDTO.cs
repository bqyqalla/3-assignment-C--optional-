using System;
namespace v._39
{
	public class WordsDTO
	{
		public string [] MyWord { get; set; }
		public bool MyBool { get; set; }
		public string MyString { get; set; }

		public WordsDTO(string[] myword, bool mybool, string mystring)
		{
			MyWord = myword;
			MyBool = mybool;
			MyString = mystring;

        }
	}
}


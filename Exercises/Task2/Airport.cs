using System;
using System.Text.RegularExpressions;

namespace Task2
{
	public class Airport

	{
		public string Code { 
			get { return Code; }
			set
			{
				string pattern = "^[A-Z]{3}";
				if(Regex.IsMatch(value, pattern))
                {
					Code = value;
                }
				else
                {
					Console.WriteLine("Wrong format of input, try again!");
                }

			}
		} // exactly 3 uppercase letters, use regexp
		public string City {
			get { return City; }
			set {
				string pattern = "^[a-zA-Z0-9.,-]{1-50}";
				if (Regex.IsMatch(value, pattern))
				{
					City = value;
				}
				else
				{
					Console.WriteLine("Wrong format of input, try again!");
				}
			}
		} // 1-50 characters, made up of uppercase and lowercase letters, digits, and .,- characters
		public double Latitude { get; set; }
		public double Longitude { get; set; } // -90 to 90, -180 to 180
		public int ElevationMeters { get; set; } //-1000 to 10000
		public string DataLine { get; set; }
		public Airport(string Code, string City, double Lat, double Lng, int ElevM)
        {
			this.Code = Code;
			this.City = City;
			this.Latitude = Lat;
			this.Longitude = Lng;
			this.ElevationMeters = ElevM;
        }
		
		Airport(string DataLine) 
		{
			this.DataLine = DataLine;
		}

		public override string ToString()
		{
			return Code + " located in " + City + " Latidude: " + Latitude + " Longitude: " + Longitude + " Elevation(in meters): " + ElevationMeters;
		}
		public void ToDataString(string[] lines) 
		{
			System.IO.File.WriteAllLines(@"C:\Users\pc\Documents\John Abbott College\12. C#\Week 1\WriteLines.txt", lines);
		}



	}
}

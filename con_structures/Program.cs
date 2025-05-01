using System;
					
public class Program
{
	public void travelMode() {
		string mode;
		Console.WriteLine("Select mode of travel: Bus, Train, or Flight");
		mode = Console.ReadLine();
		
		switch(mode) {
			case "Bus":
				Console.WriteLine("Booking bus ticket.");
				break;
			case "Train":
				Console.WriteLine("Booking train ticket.");
				break;
			case "Flight":
				Console.WriteLine("Booking plane ticket.");
				break;
			default:
				Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
				break;
		}
	}
		
	public void getDiscount() {
		int age;
		Console.WriteLine("Input user age:");
		age = int.Parse(Console.ReadLine());

		if (age < 12) {
			Console.WriteLine("Half price ticket.");
		} else if (age <= 65) {
			Console.WriteLine("Full price ticket.");
		} else {
			Console.WriteLine("Senior discount ticket.");
		}
	}
	
	public static void Main()
	{
		Program p = new Program();
		p.travelMode();
		p.getDiscount();
	}
}
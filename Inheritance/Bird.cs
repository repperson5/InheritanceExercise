using System;
namespace Inheritance
{
	public class Bird : Animal 
	{
		public Bird()
		{
			Breed = "parakeet";
			Legs = 2;
			HasFur = false;
			Color = "Green";
		}

		public bool CanFly { get; set; } = true;
		public bool HasFeathers { get; set; } = true;
		public bool CanChirp { get; set; } = true;
		public bool BuildsNest { get; set; }

		//Method
		public void PrintDetails()
		{
			Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($" Breed: {Breed}");
            Console.WriteLine($" Legs: {Legs}");
            Console.WriteLine($" HasFur: {HasFur}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"CanFly:{CanFly}");
            Console.WriteLine($"BuildsNest:{BuildsNest}");

        }


	}
}


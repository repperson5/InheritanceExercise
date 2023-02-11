using System;
namespace Inheritance
{
	public class Reptile:Animal
	{
		public Reptile()
		{
            Breed = "snake";
            Legs = 0;
            HasFur = false;
            Color = "Black";
        }

        public bool IsColdBlooded { get; set; } = true;
        public string Noise { get; set; }
        public bool HasSacles { get; set; } = true;
        public bool HasForkedTongue { get; set; } = true;

        public void PrintDetails()
        {
            Console.WriteLine($"{GetType().Name}");
            Console.WriteLine($" Breed: {Breed}");
            Console.WriteLine($" Legs: {Legs}");
            Console.WriteLine($" HasFur: {HasFur}");
            Console.WriteLine($"Color:{Color}");
            Console.WriteLine($"IsColdBlooded:{IsColdBlooded}");
            Console.WriteLine($"Noise:{Noise}");
        }


	}
}


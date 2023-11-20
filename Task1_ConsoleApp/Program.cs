namespace Task1_ConsoleApp
{
	class Program
	{
		static void Main()
		{
			Hamster hamster = new("iman", true, HamsterSpecies.Syrian);
            Console.WriteLine(hamster.Name);
            Console.WriteLine(hamster.GetHamsterDescription());
        }
	}
}

namespace Task2_ConsoleApp
{
	class Program
	{
		static void Main()
		{
			Hamster hamster = new Hamster("Mimi",new Burrow(10.7, 10.8, "RockyBurrow", eCoziness.Rocky, 1, false));
			string result= hamster.GetBurrowDescription(true);
            Console.WriteLine(result);
        }
	}
}

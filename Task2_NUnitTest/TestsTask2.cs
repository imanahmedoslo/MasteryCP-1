using Task2_ConsoleApp;

namespace Task2_NUnitTest
{
	public class TestsTask2
	{
		[Test]
		public void Test_APetHamsterWhoDoesNotLikeFood()
		{
			Hamster hamster = new("Maximilian", true, HamsterSpecies.Campbell);

			string result = hamster.GetHamsterDescription();

			Assert.That(result, Is.EqualTo("Maximilian is a pet Campbell hamster. Maximilian doesn't like any food."));
		}

		[Test]
		public void Test_APetHamsterWhoLikesThreeTypesOfFood()
		{
			Hamster hamster = new("Dexter", true, HamsterSpecies.Syrian);
			hamster.FoodList = new List<string> { "seeds", "fruits", "insects" };

			string result = hamster.GetHamsterDescription();

			Assert.That(result, Is.EqualTo("Dexter is a pet Syrian hamster. Dexter likes 3 types of food."));
		}

		[Test]
		public void Test_APetHamsterWhoLikesTwoTypesOfFood()
		{
			Hamster hamster = new("Chiquita", true, HamsterSpecies.Roborovski);
			hamster.FoodList = new List<string> { "fruits", "insects" };

			string result = hamster.GetHamsterDescription();

			Assert.That(result, Is.EqualTo("Chiquita is a pet Roborovski hamster. Chiquita likes 2 types of food."));
		}

		[Test]
		public void Test_AWildHamsterWhoLikesOneTypeOfFood()
		{
			Hamster hamster = new("Goldilocks", false, HamsterSpecies.WinterWhite);
			hamster.FoodList = new List<string> { "insects" };

			string result = hamster.GetHamsterDescription();

			// Info to students: note that we expect the word "type" instead of "types" toward the end of the sentence.
			Assert.That(result, Is.EqualTo("Goldilocks is a wild WinterWhite hamster. Goldilocks likes 1 type of food."));
		}

		[Test]
		public void Test_AHamsterCreatedWithAlternativeConstructor()
		{
			Burrow burrow = new(10.77, 20.55);
			// Create a new constructor in the Hamster class so this test will pass. The new constructor should 
			// give some default values for the hamster: WinterWhite species, is not a pet, insects in FoodList.
			Hamster hamster = new("Jojo", burrow);

			// Info to students: Depending on your computer's language/localization, you might get problems with decimal numbers.
			// If you get the wrong number of decimals, or if you get '.' instead of ',' as a decimal separator, use this way of 
			// converting your number to a string inside the GetBurrowDescription method: 
			// string variableConverted = variablenameToConvert.ToString("F2", CultureInfo.GetCultureInfo("no-NO"));
			// The setup above requires a namespace: "using System.Globalization;". It should force 2 decimals and use ',' as the 
			// decimal separator. (If it still doesn't work, Google it or notify your teacher for help.)
			string burrowPosition = hamster.GetBurrowDescription();

			Assert.That(burrowPosition, Is.EqualTo("Jojo has a burrow at longitude 10,77 and latitude 20,55."));
			Assert.That(hamster.IsPet, Is.False);
			Assert.That(hamster.GetHamsterDescription(), Is.EqualTo("Jojo is a wild WinterWhite hamster. Jojo likes 1 type of food."));
			Assert.That(hamster.FoodList, Has.Count.EqualTo(1));
			Assert.That(hamster.FoodList[0], Is.EqualTo("insects"));

			// Now Jojo doesn't have a burrow anymore. :-(
			hamster.Burrow = null;

			Assert.That(hamster.GetBurrowDescription(), Is.EqualTo("Jojo doesn't have a burrow."));
		}
    }
}

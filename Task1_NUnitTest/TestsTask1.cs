using Task1_ConsoleApp;

namespace Task1_NUnitTest
{
	public class TestsTask1
	{
		[Test]
		public void Test_AddThreeAndFive()
		{
			// Arrange
			// This part is intentionally left blank.

			// Act
			int result = MathAndTextFormatting.Add(3, 5);

			// Assert
			Assert.That(result, Is.EqualTo(8));
		}

		[TestCase(0, 3, 3)]
		[TestCase(3, 5, 8)]
		[TestCase(10, 11, 21)]
		public void TestCase_AddTwoNumbers(int number1, int number2, int expected)
		{
			// Arrange
			// This part is intentionally left blank.

			// Act
			int result = MathAndTextFormatting.Add(number1, number2);

			// Assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase(0, 3, 4, 12)]
		[TestCase(2, 1, 5, 15)]
		[TestCase(5, 4, 3, 27)]
		public void TestCase_FirstAddThenMultiply(int number1, int number2, int number3, int expected)
		{
			// Arrange
			// This part is intentionally left blank.

			// Act
			int sumOfAdd = MathAndTextFormatting.Add(number1, number2);
			int result = MathAndTextFormatting.Multiply(sumOfAdd, number3);

			// Assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase("aaa", true, true, "-:AAA:-")]
		[TestCase("aaa", true, false, "AAA")]
		[TestCase("aaa", false, true, "-:aaa:-")]
		[TestCase("aaa", false, false, "aaa")]
		public void TestCase_PossiblyUppercaseAndDecorateText(string text, bool toUppercase, bool decorate, string expected)
		{
			// Arrange
			// This part is intentionally left blank.

			// Act
			string result = MathAndTextFormatting.PossiblyUppercaseAndDecorateText(text, toUppercase, decorate);

			// Assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase(-5555, "-5555 is a negative number")]
		[TestCase(-1, "-1 is a negative number")]
		[TestCase(92, "Add 8 to 92 and you get 100")]
		[TestCase(95, "Add 5 to 95 and you get 100")]
		[TestCase(100, "Add 0 to 100 and you get 100")]
		[TestCase(101, "101 is greater than 100")]
		[TestCase(4444, "4444 is greater than 100")]
		public void TestCase_TellIfNegativeOrTheRelationTo100(int number, string expected)
		{
			// Arrange
			// This part is intentionally left blank.

			// Act
			string result = MathAndTextFormatting.TellIfNegativeOrTheRelationTo100(number);

			// Assert
			Assert.That(result, Is.EqualTo(expected));
		}

		[TestCase("Nemo", true, HamsterSpecies.Roborovski, "Nemo is a pet Roborovski hamster.")]
		[TestCase("Kernel", false, HamsterSpecies.Syrian, "Kernel is a wild Syrian hamster.")]
		[TestCase("Dexter", true, HamsterSpecies.Syrian, "Dexter is a pet Syrian hamster.")]
		public void TestCase_GetHamsterDescription(string name, bool isPet, HamsterSpecies hamsterSpecies, string expected)
		{
			// Arrange
			Hamster hamster = new(name, isPet, hamsterSpecies);

			// Act
			string result = hamster.GetHamsterDescription();

			// Assert
			Assert.That(result, Is.EqualTo(expected));
		}
	}
}
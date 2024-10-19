namespace Hangman
{
	public class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Welcome to Hangman!");
			string[] listOfWords = new string[10];
			listOfWords[0] = "sheep";
			listOfWords[1] = "goat";
			listOfWords[2] = "computer";
			listOfWords[3] = "lemon";
			listOfWords[4] = "watermelon";
			listOfWords[5] = "icecream";
			listOfWords[6] = "jasmine";
			listOfWords[7] = "pineapple";
			listOfWords[8] = "orange";
			listOfWords[9] = "mango";

			Random random = new Random();

			var indx = random.Next(listOfWords.Length);

			string mysteryWord = listOfWords[indx];

			char[] guess = new char[mysteryWord.Length];

			for (int i = 0; i < mysteryWord.Length; i++)
			{
				guess[i] = '*';
			}

			int wrongGuesses = 0;
			int maxAttempts = 6;

			Console.WriteLine("Enter your guess: ");

			while (true)
			{
				string input = Console.ReadLine();

				if(string.IsNullOrEmpty(input) || input.Length != 1)
				{
					Console.WriteLine("Invalid input. Please enter a single character.");
					continue;
				}

				char playerGuess = char.ToLower(input[0]);
				bool isGuessCorrect = false;
                for (int j = 0; j < mysteryWord.Length; j++)
                {
					if (playerGuess == mysteryWord[j])
					{
						guess[j] = playerGuess;
						isGuessCorrect = true;
					}
                }

				if (!isGuessCorrect)
				{
					wrongGuesses++;
                    Console.WriteLine($"Wrong guess! You have {maxAttempts - wrongGuesses} attempts left!");
                }

				Console.WriteLine(guess);

				if(new string(guess) == mysteryWord)
				{
					Console.WriteLine("Congratulations! You guessed the word!");
					break;
				}

				if (wrongGuesses >= maxAttempts)
				{
                    Console.WriteLine("Game over! You've run out of attempts.");
                    Console.WriteLine($"The correct word was: {mysteryWord}");
					break;
                }
            }
        }
	}
}

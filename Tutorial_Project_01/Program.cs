using System;

// namespace
namespace Tutorial_Project_01
{
	// class
	class MainClass
	{
		//Function (entry point)
		public static void Main(string[] args)
		{
			// Starting point of everything
			Console.WriteLine("Hello, this is my first C# String!");

			//Creating a string and naming it under the variable "Kyler:"
			//Any time Kyler is pulled, it will be replaced with this string.
			string Kyler = "Hello, this is string number 2!";

			//Using the variable to print the string
			Console.WriteLine(Kyler);

			//Defining a new variable with a new string.
			string a = "This string is under the variable a";

			//Writing the string with variable A
			Console.WriteLine(a);


			//Start of "Game" creation
			// Goal is to have the user interact with the console
			//Ask user to type a number between 1 and 9
			//Have the users selection be returned to them in the form of a sentance/question.


			//Step 1
			//instruct user to select a number
			PrintFoo100Times();
			Console.WriteLine("Press a number between 1 and 9!");

			//Step 2
			//Read user input and store it as a readable item (variable)
			ConsoleKeyInfo keyInfo = Console.ReadKey();

			//Setting up an if clause. Basically if the user inputs the letter A
			if (keyInfo.KeyChar == 'a')
			//
			{
				//Response to the letter A being input
				Console.WriteLine("THAT IS NOT A NUMBER. KNOCK IT OFF!!!");
			}
			//Else statement is what follows if the "if" statement is not met.
			else
			{
				//This line says to write the script "did you type" and some others
				//the {0} is a place holder for the next part in the line
				///Next line says to pull the KeyInfo, The KeyCharacter, and apply it to the string in the place of {a}
				Console.WriteLine("Did you type {0}", keyInfo.KeyChar.ToString());

			}


		}
		//Print Foo to Screen
        //This is a function that is defined. 
        //Any time this function is called, Foo will appear in the console
        //This is outside of the main function loop so will not appear unless called uppon in the main loop
		static void PrintFooToScreen()
		{
			Console.WriteLine("Foo");
		}

        //Creat new function
		//Goal: Print Foo to screen 100 times
        static void PrintFoo100Times()
		{
			//For loop needed.
            //Int is an integer given the name counter
            //This line says for every time the counter gets passed and is less than 100, add 1.
			for (int counter = 0; counter <= 99; counter++)
			{
				//instead of writing a new function of writing foo, use the function that already exists.
				PrintFooToScreen();

			}
		}


    }
}


// Misc notes:
// A library is a setup of pre built tools to use.

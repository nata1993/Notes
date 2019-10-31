/*HERE ARE ALL THE NOTES I ACCUMULATED OVER THE TIME DURING C# LANGUAGE STUDY.
 * NEED TO DINF SOMETHING? JUST CTRL + F AND INSERT "NOTE + NUMBER" LIKE "NOTE 1"
 * IF WANT TO TEST SOME OF THOSE NOTES, JUST REMOVE "/ *" AND "* /" AT THE BEGINNING AND AT THE END OF EACH NOTE.
 * 
 * NOTE 1 - REVERSING ORDER OF WORDS AND NUMBERS USING CONSOLE.WRITELINE($"... {VARIABLE 1}.") (STRING INTERPOLATION).
 * NOTE 2 - FUNCTION - SUM NUMBERS WHERE SUM FUNCTION IS CALLED OUT SEPARATELY.
 * NOTE 3 - CASE/BREAK/DEFAULT.
 * NOTE 4 - PRESENTING DATA TO USER IN THREE DIFFERENT WAYS, INCLUDING STRING INTERPOLATION.
 * NOTE 5 - MATHEMATICS - NB!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! unfinished with explanations
 * NOTE 6 - TERNARY OPERATOR - NUMBERS AND WORDS - ONLY WORKS IF OUTCOME IS ONLY TRUE AND FALSE.
 * NOTE 7 - INPUT EQUALS OUTPUT.
 * NOTE 8 - RANDOM NUMBER GENERATOR
 * NOTE 9 - FUNCTION - WRITING DIFFERENTLY SAME STUFF
 * NOTE 10 - FOR LOOP
 * NOTE 11 - FOREACH
 * NOTE 12 - CAPTIONS
 * NOTE 13 - ARRAY
 * NOTE 14 - RETURN VALUE OF FUNCTION
 * NOTE 15 - SPLIT(), INDEXOF, TRIM(), SUBSTRING
 */

using System;

namespace Notes
{
    class Program
    {
        //NOTE 15

        /*static void Main()
        {
            string fullName = "Bogdan*Parubok**";
            Console.WriteLine($"Full name ammount of characters before trim: {fullName.Length}");
            Console.WriteLine($"How it looks before trim: {fullName}");
            Console.WriteLine("\n");
            fullName = fullName.Trim('*'); //trimms string from both sides and strips whitespace from string
            Console.WriteLine($"Full name ammount of characters after trim: {fullName.Length}");
            Console.WriteLine($"How it looks after trim: {fullName}");
            Console.WriteLine("\n");
            int indexOfSpace = fullName.IndexOf('*'); //assigning "space" or any other character which index is needed to be found. Found is only one, the first character
            Console.WriteLine($"The position of symbol \" * \" is: {indexOfSpace}"); //position is counted from 0 hence if indexOfSpace is 6, actual position is 7
            Console.WriteLine("\n");
            //substring splits string into multiplie smaller strings
            string firstName = fullName.Substring(0, indexOfSpace);
            Console.WriteLine($"First substring is: {firstName}");
            string lastName = fullName.Substring(indexOfSpace + 1); // +1 here adds index, else it adds that "space" to the word 
            Console.WriteLine($"Second substring is: {lastName}");
            Console.WriteLine("\n");
            //splits string in specified place and prints it out
            string[] personalData = fullName.Split('*');
            int count = 1;
            foreach (string value in personalData)
            {
                Console.WriteLine($"Splitted string substring nr {count}: {value}");
                count++;
            }
        }*/

        //NOTE 14

        /*static void Main()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("When you were born?");
            int yearOfbirth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your age is {Age(yearOfbirth)}.");
        }
        public static int Age(int yearOfbirth)  // addind just return, returns nothing. return must have returnable variable after return.
        {
            int result = 2019 - yearOfbirth;
            return result; //OR
            return 2019 - yearOfbirth;
        }*/

        //NOTE 13

        //Blank data array with function

        /*static void Main()
        {
            Console.WriteLine("Insert your name and age separated by comma.");
            string userInput = Console.ReadLine();

            PersonalDataBlank(userInput);
        }

        public static void PersonalDataBlank(string userInput)
        {
            string[] personalData = userInput.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\n");
            Console.WriteLine("The blank of user personal data:");
            Console.WriteLine(personalData[0]);
            Console.WriteLine(personalData[1]);
            Console.WriteLine(personalData[2]);
        }*/

        /*static void Main()
        {
            // first [] shows that int variable will be initalized as array, second [] shows how big array will be, {defined variables in array}
            // remove {} to make array empty
            int[] arrayName = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(arrayName); //just shows how big in bits the array is and its type

            //manualy showing each indexed variable in array if there is any variable in array
            Console.WriteLine(arrayName[0]);
            Console.WriteLine(arrayName[1]);
            Console.WriteLine(arrayName[2]);
            Console.WriteLine(arrayName[3]);
            Console.WriteLine(arrayName[4]);
            Console.WriteLine("\n");

            // automatically adding variables to array, i is incremented and written to array with for loop as much as the array lenght is
            // array lenght is defined by the second [] in the called array
            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i]);
            }
            Console.WriteLine("\n");

            //reversed array
            //for loop looks at array indexes, not how much it is exactly written in array. Index starts from zero, hence why it is used -1.
            for (int i = arrayName.Length - 1; i >= 0; i--)
            {
                arrayName[i] = arrayName[i] * 100; // destructive array values change since variables are phisically changed in the array
                Console.WriteLine(arrayName[i]);
            }
            Console.WriteLine("\n");

            //overwriting array values
            //myFirstarray[4] = myFirstarray[4] * 100;
            //myFirstarray[0] = 100;

            for (int i = 0; i < arrayName.Length; i++)
            {
                Console.WriteLine(arrayName[i] * 100); // non-destructive array value change since writeline just shows how variables would be changed
            }*/

        //NOTE 12

        /*static void Main()
        {
            Console.WriteLine("\"baba\""); // addind \" \" between "" and word, adds " " to the word.
        }*/

        //NOTE 11       

        //Adding break between characters
        /*static void Main()
        {
            string word;
            Console.WriteLine("insert word");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++ )
            {
                Console.Write($"{word[i]} ");
            }
        }*/

        //Adding break between characters
        /*static void Main()
        {
            string name;
            Console.WriteLine("insert word");
            name = Console.ReadLine();

            foreach (char letter in name)
            {
                Console.Write($"{letter} ");
            }
        }*/

        //Finding character and counting them
        /*static void Main()
        {
            string word;
            bool lFound = false;
            int count = 0;
            Console.WriteLine("insert word");
            word = Console.ReadLine();

            foreach (char letter in word)
            {
                if (letter == 'a')
                {
                    lFound = true;
                    count++;
                }
            }
            string result = lFound ? $"it has a and have them as much as {count}" : "does not have";
            Console.WriteLine(result);
        }*/

        /*static void Main()
        {
            Console.WriteLine("Insert word");
            string name = Console.ReadLine();
            int counter = 0;

            foreach (char letter in name)
            {
                counter++;
            }
            Console.WriteLine($"Word consists of {counter} characters.");
        }*/

        //NOTE 10

        /*public static void Main()
        {
            int count = 0;

            for (int i = 1; i <= 100; i++) //i = 1 is the from where the loop starts, i <= 100 is when the loop ends, i++ dictates how long the loop goes until it hits i <= 100
            {
                if (i % 3 == 0) //i in the for loop statement is divided by 3
                {
                    count++;
                }
            }
            Console.WriteLine($"total {count}");
        }*/

        //NOTE 9

        /*static void Main()  //WAY ONE
        {
            //Note here that int nr1 and nr2 are used only in Main while int name and int color in the function are used only in function
            //and are independent of each other. In function you can use any name for function variables as long as in the Main the function calling
            //is using variables in Main
            Console.WriteLine("Insert number 1.");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2.");
            int nr2 = int.Parse(Console.ReadLine());
            Sum(nr1, nr2);
        }

        public static void Sum(int name, int color)
        {
            Console.WriteLine(name + color);
        }*/

        /*static void Main()  //WAY TWO
        {
            Console.WriteLine($"{Sum()}");
        }

        public static int Sum()
        {
            Console.WriteLine("Insert number 1.");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2.");
            int nr2 = int.Parse(Console.ReadLine());
            int nr3 = nr1 + nr2;
            return nr3;
        }*/

        /*static void Main() // WAY THREE
        {
            Console.WriteLine("Insert number 1.");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2.");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(nr1, nr2));
        }

        public static int Sum(int nr1, int nr2)
        {
            int c = nr1 + nr2;
            return c;
        }*/

        /*static void Main()
        {
            Console.WriteLine("Insert number 1.");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert number 2.");
            int nr2 = int.Parse(Console.ReadLine());
            Sum(nr1, nr2);
            Console.WriteLine($"{nr1 + nr2}");
        }

        public static int Sum(int nr1, int nr2)
        {
            int c = nr1 + nr2;
            return c;
        }*/

        //NOTE 8

        /*static void Main()
        {
            //Outside of "while"it generates number only once. Put inside "while" and you get unlimited random numbers as long as "while" is running.

            Random rndGen = new Random();
            int rndNum = rndGen.Next(1, 7);
            Console.WriteLine($"{rndNum}");
        }*/

        //NOTE 7

        /*
        static void Main()
        {        
            Console.WriteLine("Choose your poison gentelmen!");
            string userChoice = Console.ReadLine();
            Console.WriteLine($"here is your {userChoice}.");
        }*/

        //NOTE 6

        /*
        static void Main(string[] args)
        {
            //Ternary Operator (with numbers) - only works if there is only two outcomes - TRUE or FALSE outcomes
            int x;
            Console.WriteLine("Enter your birth year please.");
            x = int.Parse(Console.ReadLine());
            string answer = (x % 4 == 0) ? "Leap year." : "Not a leap year.";
            Console.WriteLine(answer);
            //Ternary Operator with words
            Console.WriteLine("Choose your poison gentelmen! Whiskey or rum?");
            string userChoice = Console.ReadLine();
            string choice = userChoice == "rum" ? "Here is your rmm, sir!" : "Here is your whiskey, sir!";
            Console.WriteLine(choice);
        }*/

        //NOTE 5

        /*
        static void Main()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(a + b); //Liitmine
            Console.WriteLine(a - b); //Lahutamine
            Console.WriteLine(a * b); //Korrutamine
            Console.WriteLine(a / b); //Jagamine
            Console.WriteLine(a = b); //Muutmine üht teiseks
            Console.WriteLine(a += b); //
            Console.WriteLine(a -= b); //
            Console.WriteLine(a *= b); //
            Console.WriteLine(a /= b); //
            Console.WriteLine(a % b); //Kui palju jääb järgi. Nt: 25 % 5 = 0, 26 % 5 = 1 ehk 25 -5 -5 -5 -5 -5 = 0
            //Comparison operators
            Console.WriteLine(a == b); //Kas a võrdub b
            Console.WriteLine(a != b); //Kas a ei võrdu b
            Console.WriteLine(a < b); //Kas a on väiksem kui b
            Console.WriteLine(a > b); //Kas a on suurem kui b
            Console.WriteLine(a <= b); //Kas a on väiksemvõrdne kui b
            Console.WriteLine(a >= b); //Kas a on suuremvõrdne kui b
            //Logical operators
            // && = and
            // || = or
            // !() = not
            Console.WriteLine(a != b && b == 2);  //a ei võrdu b ja b võrdub 2
            Console.WriteLine(a != b && b == 10); //a ei võrdu b ja b võrdub 10
            Console.WriteLine(a != b || b == 2);  //a ei võrdu b või b võrdub 2
            Console.WriteLine(!(b == 10));        // b ei võrdu 10
        }*/

        //NOTE 4

        /*
        /tatic void Main()
        {
            string firstName;
            string lastName;
            int x;
            Console.WriteLine("What is your first name?");                      //Presenting data to user as ("..");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("Your name is {0} {1}", firstName, lastName);     //Presenting data to user as ("...{0}.", var1);
            Console.WriteLine($"Hello, {firstName} {lastName}.");               //Presenting data to user as ($"... {var1}."); - String interpolatiion
            Console.WriteLine("Whats your borning age?");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine($"You were born in year {x}.");
            Console.WriteLine($"Your age is: {2019 - x}");
        }*/

        //NOTE 3

        /*
        static void Main()
        {
            Console.WriteLine("pick colour");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "red":
                    Console.WriteLine("you are romantic type");
                    break;
                case "black":
                    Console.WriteLine("you are loner");
                    break;
                case "blue":
                    Console.WriteLine("seadog");
                    break;
                default:
                    Console.WriteLine("wtf");
                    break;
            }
        }*/

        //NOTE 2

        /*
        static int Sum(int nr1, int nr2)
        {
            int sum1 = nr1 + nr2;
            return sum1;
        }

        static void Main()
        {
            Console.WriteLine("Enter number one:");
            int nr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two:");
            int nr2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of variables is {0}.", Sum(nr1, nr2));
        }*/

        //NOTE 1

        /*
        static void Main()
        {

            string wor1, wor2, temp1;
            wor1 = Console.ReadLine();
            wor2 = Console.ReadLine();
            temp1 = wor1;
            wor1 = wor2;
            wor2 = temp1;
            Console.WriteLine($"{wor1}");
            Console.WriteLine($"{wor2}");
            int num1, num2, temp2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            temp2 = num1;
            num1 = num2;
            num2 = temp2;
            Console.WriteLine($"{num1}");
            Console.WriteLine($"{num2}");
        }*/
    }
}
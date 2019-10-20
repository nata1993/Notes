/*HERE ARE ALL THE NOTES I ACCUMULATED OVER THE TIME DURING C# LANGUAGE STUDY.
 * NEED TO DINF SOMETHING? JUST CTRL + F AND INSERT "NOTE + NUMBER" LIKE "NOTE 1"
 * IF WANT TO TEST SOME OF THOSE NOTES, JUST REMOVE "/ *" AND "* /" AT THE BEGINNING AND AT THE END OF EACH NOTE.
 * 
 * NOTE 1 - REVERSING ORDER OF WORDS AND NUMBERS USING CONSOLE.WRITELINE($"... {VARIABLE 1}.") (STRING INTERPOLATION).
 * NOTE 2 - SUM NUMBERS WHERE SUM FUNCTION IS CALLED OUT SEPARATELY.
 * NOTE 3 - CASE/BREAK/DEFAULT.
 * NOTE 4 - PRESENTING DATA TO USER IN THREE DIFFERENT WAYS, INCLUDING STRING INTERPOLATION.
 * NOTE 5 - MATHEMATICS - NB!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! unfinished with explanations
 * NOTE 6 - TERNARY OPERATOR - NUMBERS AND WORDS - ONLY WORKS IF OUTCOME IS ONLY TRUE AND FALSE.
 * NOTE 7 - INPUT EQUALS OUTPUT.
 * 
 */

using System;

namespace Notes
{
    class Program
    {
        //NOTE 7

        /*
        static void Main()
        {        
            Console.WriteLine("Choose your poison gentelmen!");
            string userChoice = Console.ReadLine();
            Console.WriteLine($"here is your {userChoice}.");
            Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();
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
            Console.ReadLine();
        }*/
    }
}
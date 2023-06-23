namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreesCompany()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckIfEqual(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");
            }
        }

        
        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int input)
        {
            if (input > 0)
            {
                Console.WriteLine($"{input} is a positive number");
            }
            else if (input < 0)
            {
                Console.WriteLine($"{input} is a negative number");
            }
            else if (input == 0)
            {
                Console.WriteLine($"{input} is neither negative or positive");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanYouVote(int age)
        {
            //Console.WriteLine("Are you old enough to vote?");
            //var age = int.Parse(Console.ReadLine());

            if (age == 18)
            {
                Console.WriteLine("You just made it!");
            }
            else if (age > 18)
            {
                Console.WriteLine("You're good to go! Choose wisely.");
            }
            else if (age < 18)
            {
                Console.WriteLine("I am sorry, maybe next election");
            }
            
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void RangeCheck(int input)
        {
            if (input <= 10 && input >= -10)
            {
                Console.WriteLine("You are in range");
            }
            else
            {
                Console.WriteLine("You are not in range");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable(int user)
        {
            
            for (var i = 1; i <= 12; i++)
            {
                Console.WriteLine(i * i);
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Console.WriteLine("Are you old enough to vote? Insert age here");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number here");
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine("Input a number from 1 - 12");
            var user = int.Parse(Console.ReadLine());

            Thousands();
            ThreesCompany();
            CheckIfEqual(7, 7);
            EvenOrOdd(7);
            PosOrNeg(7);
            CanYouVote(age);
            RangeCheck(input);
            MultTable(user);
        }
    }
}

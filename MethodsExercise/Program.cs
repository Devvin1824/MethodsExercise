﻿namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine("what is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal?");
            string animal = Console.ReadLine();
            
            Console.WriteLine($"One day, sometime after lunch but not quite yet dinner time, {name} was walking to their favorite store (CVS Pharmacy) \n" +
                $"while listening to their favorite band {band} on their brand new {color} ipod shuffle. When they were about 20 feet away from getting \n" +
                $"to the store, a {animal} ran into them and knocked them into another dimension. To this day, nobody has seen or heard from {name}.");

            int sum;
            int product;
            int answer;
            int quotient;
            int remainder;

            sum = Functions.Add(2, 4);
            product = Functions.Multiply(10, 2);
            answer = Functions.Subtract(8, 5);
            quotient = Functions.Divide(20, 10);
            remainder = Functions.Modulus(20, 7);

            Console.WriteLine($"The sum is {sum}.");
            Console.WriteLine($"The product is {product}.");
            Console.WriteLine($"The answer is {answer}.");
            Console.WriteLine($"The quotient is {quotient}.");
            Console.WriteLine($"The remainder is {remainder}.");

            Console.WriteLine(Functions.AddChallenge(3, 6, 7));
           
        }
    }
}

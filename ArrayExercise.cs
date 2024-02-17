using System;

namespace FinalTest
{
    public class ArrayExercise
    {
        public void Execute()
        {
            Console.WriteLine("\nArray Exercise:");

            //----------------------------------------------------------------------------------------------------------
            // Exercise:   1. Create an int array named first10Primes and use array initialization to initialize it to
            //                 the first 10 prime numbers (2,3,5,7,11,13,17,19,23,29).
            //             2. Write a static void method called Square() that takes an int by ref and squares it.
            //             3. Using a for loop, loop through the array and print the first 10 primes.
            //             4. Using another for loop, loop through the array and call Square() passing each element by ref.
            //             5. Using another for loop, loop through the updated array and print the resulting squared primes.


            //TODO: Array Exercise: Add code here to create and process array
            int[] first10Primes = {2,3,5,7,11,13,17,19,23,29};

            for(int i = 0; i<10; i++){
                Console.WriteLine(first10Primes[i]);
            }

            for(int i = 0; i<10; i++){
                Square(ref first10Primes[i]);
            }

            for(int i = 0; i<10; i++){
                Console.WriteLine(first10Primes[i]);
            }
        }

        public void Square(ref int numbers)
        {
            numbers = numbers * numbers;
        } 
    }
}

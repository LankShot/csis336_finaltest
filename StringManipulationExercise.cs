using System;

namespace FinalTest
{
    public class StringManipulationExercise
    {
        public void Execute()
        {
            Console.WriteLine("\nString Manipulation Exercise:");


            //----------------------------------------------------------------------------------------------------------
            // Exercise:    Given the string array below, write code to loop through all 5 strings and use string 
            //              manipulation methods to find the last instance of the string "is".  Skip the next 5 
            //              characters after the string "is" and then write out the subsequent 5 characters
            //              followed by a newline.
            //
            //              For example, if the string was "This is a testing string", the code would write "sting".
            //                                                   ^ ^   ^^   ^ 
            //                                                   | |   ||   |
            //                                                   |  \ /  \ /
            //                                                   |   |    |
            //                                                   |   |    5 Characters to write = "sting"
            //                                                   |   |
            //                                                   |   5 Characters to skip
            //                                                   |      
            //                                                  The last instance of "is"

            string[] strings = {
                "A word of advice for this,   'Don't let the sentences throw you off, they are just arrays of characters!'",
                "If you use your head and your book, this exercise is no  sweat!",
                "Here is a sentence with   lots of  spaces in it,   but it is not the  spaces   that cause problems because they are just characters",
                "This one is: so small.",
                "The problem should be solvable.  All you need to know is fun stuff that we learned over the semester!"
            };

            foreach(string str in strings){
                string temp = str.Substring(str.LastIndexOf("is")+2, 10);
                temp = temp.Substring(5,5);
                Console.WriteLine(temp);
            }

        }
    }
}

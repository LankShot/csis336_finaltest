using System;

namespace FinalTest
{
    public class EnumsAndSwitchExercise
    {

        enum Severity
        {
            Low,
            Medium,
            High,
            Critical
        }

        static bool RequiresAction(Severity sev)
        {
            switch(sev){
                case Severity.Low:
                    return  false;

                case Severity.Medium:
                    return false;

                case Severity.High: 
                    return true;
                    
                case Severity.Critical:
                    return true;

                default:
                    return false;
            }
        }
        public void Execute()
        {
            Console.WriteLine("\nEnum and Switch Exercise:");

            //----------------------------------------------------------------------------------------------------------
            // Exercise:    Implement an enum called Severity with 4 levels: Low, Medium, High and Critical.  Then,
            //              implement a boolean method with the following signature: 
            //                  static bool RequiresAction(Severity sev)
            //              This method should use a switch statement to return true for High and Critical severity and
            //              false for Low and Medium severity.  Finally, create an array initialized with all 4 severities, 
            //              loop through the array and write out the severity followed by the result of a call to your new 
            //              method separated by a colon.
            //
            //              Example output: Critical:True


            
            Severity[] sevs = {Severity.Low, Severity.Medium, Severity.High, Severity.Critical};

            foreach(Severity sev in sevs){
                Console.WriteLine($"{sev}:{RequiresAction(sev)}");
            }
            
            
        }
    }
}

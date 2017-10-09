using Basic;
using System;

namespace Exercises.c1.l1
{
    public class ExamLauncher
    {
        //Create a class called Test that has data members for a student’s name and
        //a number indicating the test number.This class is used in the following
        //scenario: When a student turns in a test, they place it face down on the
        //desk.If a student wants to check an answer, the teacher has to turn the stack
        //over so the first test is face up, work through the stack until the student’s
        //test is found, and then remove the test from the stack.When the student
        //finishes checking the test, it is reinserted at the end of the stack.
        //Write a Windows application to model this situation.Include text boxes
        //for the user to enter a name and a test number. Put a list box on the form
        //for displaying the final list of tests. Provide four buttons for the following
        //actions: 1. Turn in a test; 2. Let student look at test; 3. Return a test; and 4.
        //Exit.Perform the following actions to test your application: 1. Enter a name
        //and a test number.Insert the test into a collection named submittedTests; 2.
        //Enter a name, delete the associated test from submittedTests, and insert the
        //test in a collection named outForChecking; 3. Enter a name, delete the test
        //from outForChecking, and insert it in submittedTests; 4. Press the Exit
        //button.The Exit button doesn’t stop the application but instead deletes all
        //tests fromoutForChecking and inserts them in submittedTests and displays
        //a list of all the submitted tests.
        public static void Launch()
        {
            Exam<UserCollection> exam = new Exam<UserCollection>();
            Console.WriteLine("Select an option: 1. Turn in; 2. Look test; 3. Return a test; 4. Exit");
            string key = Console.ReadLine();
            while (key != "4") {
                string name = string.Empty;
                switch (key) {
                    case "1":
                        exam.TurnIn(exam.GetName());
                        exam.ShowSubmitted();
                        exam.ShowOutChecking();
                        key = Console.ReadLine();
                        break;
                    case "2":
                        exam.LookTest(exam.GetName());
                        exam.ShowSubmitted();
                        exam.ShowOutChecking();
                        key = Console.ReadLine();
                        break;
                    case "3":
                        exam.ReturnTest(exam.GetName());
                        exam.ShowSubmitted();
                        exam.ShowOutChecking();
                        key = Console.ReadLine();
                        break;
                    case "4":
                        break;
                    default:
                        key = Console.ReadLine();
                        break;

                }
            }
        }
    }
}

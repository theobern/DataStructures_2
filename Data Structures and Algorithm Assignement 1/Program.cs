using System;

namespace Data_Structures_and_Algorithm_Assignement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demonstration

            //Creation of 5 student to put in a list.

            Student one = new Student("Bobby", "One", "001", 12);
            Student two = new Student("Dylan", "Two", "002", 9);
            Student three = new Student("Greg", "Three", "003", 14);
            Student four = new Student("Jeanette", "Four", "004", 13);
            Student five = new Student("Clementine", "Five", "005", 5);

            //Displaying one

            Console.WriteLine(one.ToString());

            // Creating a custom data list

            CustomDataList customList = new CustomDataList();

            customList.Add(one);
            customList.Add(two);
            customList.Add(three);
            customList.Add(four);
            customList.Add(five);

            //Displaying the custom list

            customList.DisplayList();

            //Removing first and last
            Console.WriteLine("\nRemoving first and last");

            customList.RemoveFirst();
            customList.RemoveLast();
            customList.DisplayList();

            //Get the second element, displaying it

            Console.WriteLine("\n second element display :");
            Student copy = customList.GetElement(1);
            Console.WriteLine("\n"+copy.ToString());

            //Removing the second element
            Console.WriteLine("\nRemoving the second element : ");
            customList.RemoveByIndex(1);
            customList.DisplayList();

            //Showing properties :

            Console.WriteLine("\nFirst : " + customList.First.ToString());
            Console.WriteLine("Last : " + customList.Last.ToString());
            Console.WriteLine("Length : " + customList.Length);
        }
    }
}

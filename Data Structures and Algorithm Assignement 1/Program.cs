using System;

namespace Data_Structures_and_Algorithm_Assignement_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstration

            //Creation an empty list.
            CustomDataList customList = new CustomDataList();

            //Adding Sample Data
            customList.PopulateWithSampleData();

            //Displaying the custom list
            Console.WriteLine("List Display :\n");
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

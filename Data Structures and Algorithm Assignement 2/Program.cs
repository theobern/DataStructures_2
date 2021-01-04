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

            int choice = 1;

            while (choice != 7)
            {
                choice = UserInterface(customList);
            }
        }

        static int UserInterface(CustomDataList list)
        {
            Console.WriteLine("Choose an operation (enter '1' to '9') : " +
                "\n   (1) Enter a new student" +
                "\n   (2) Display the student list" +
                "\n   (3) Sort the list" +
                "\n   (4) Show the best scoring student" +
                "\n   (5) Show the worst scoring student" +
                "\n   (6) Remove a student by index" +
                "\n   (7) Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the student's firstname");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter the student's lastname");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter the studentnumber");
                    string studentNumber = Console.ReadLine();
                    Console.WriteLine("Enter the student's AverageScore");
                    float averageScore = Convert.ToSingle(Console.ReadLine());

                    Student newStudent = new Student(firstName, lastName, studentNumber, averageScore);
                    list.Add(newStudent);

                    break;

                case 2:
                    list.DisplayList();
                    break;

                case 3:
                    Console.WriteLine("Choose sorting field (enter '1' to '4') : " +
                "\n   (1) first name" +
                "\n   (2) last name" +
                "\n   (3) student number" +
                "\n   (4) average score");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter '1' for  an ascending sort, '2' for a descending sort. ");
                    int j = Convert.ToInt32(Console.ReadLine());
                    list.Sort(j, i);

                    break;

                case 4:
                    Console.WriteLine(list.GatMaxElement().ToString());
                    break;

                case 5:
                    Console.WriteLine(list.GatMinElement().ToString());
                    break;

                case 6:
                    Console.WriteLine("Enter the student's index");
                    int k = Convert.ToInt32(Console.ReadLine());
                    list.RemoveByIndex(k);
                    break;
            }

            return choice;

        }

    }
}

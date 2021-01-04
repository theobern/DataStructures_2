using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithm_Assignement_1
{
    class CustomDataList
    {
        Student[] studentArray; //Choosed to work with array as it is way easier to work with index.


        public Student[] StudentArray
        {
            get { return this.studentArray; }
            set { this.studentArray = value; }
        }

        public int Length //Not useful as Length is already an array property but needed to be showed.
        {
            get { return studentArray.Length; }
            private set { } // private, because it makes no sense implementing the Length
        }


        //Constructor

        public CustomDataList()
        {
            studentArray = new Student[0];
        }

        public Student Last
        {
            get
            {
                int lastIndex = Length - 1;
                if (lastIndex == -1) { return null; }
                else { return studentArray[lastIndex]; }
            }
            set //Change the last, does not add an item.
            {
                int lastIndex = Length - 1;
                if (lastIndex != -1)
                {
                    studentArray[lastIndex] = value;
                }

            }
        }

        public Student First
        {
            get
            {
                if (Length == 0) { return null; }
                else { return studentArray[0]; }
            }
            set //Change the first, does not add an item.
            {
                if (Length != 0)
                {
                    studentArray[0] = value;
                }
            }
        }

        public void PopulateWithSampleData()
        {
            Student one = new Student("Bobby", "One", "001", 12);
            Student two = new Student("Dylan", "Two", "002", 9);
            Student three = new Student("Greg", "Three", "003", 14);
            Student four = new Student("Jeanette", "Four", "004", 13);
            Student five = new Student("Clementine", "Five", "005", 5);

            Add(one);
            Add(two);
            Add(three);
            Add(four);
            Add(five);
        }

        public void Add(Student newStudent)
        {
            Student[] newArray = new Student[Length + 1];
            for (int i = 0; i < Length; i++)
            {
                newArray[i] = studentArray[i];
            }
            newArray[Length] = newStudent;
            studentArray = newArray;
        }

        public Student GetElement(int index)
        {
            return studentArray[index];
        }

        public void RemoveLast()
        {
            Student[] newArray = new Student[Length - 1];
            for (int i = 0; i < Length - 1; i++)
            {
                newArray[i] = studentArray[i];
            }
            studentArray = newArray;
        }

        public void RemoveFirst()
        {
            Student[] newArray = new Student[Length - 1];
            for (int i = 0; i < Length - 1; i++)
            {
                newArray[i] = studentArray[i + 1];
            }
            studentArray = newArray;
        }

        public void RemoveByIndex(int index)
        {
            Student[] newArray = new Student[Length - 1];
            if (index == 0) { RemoveFirst(); }           //We use our previous methods designed for specific cases.
            if (index == Length - 1) { RemoveLast(); }
            else
            {
                for (int i = 0; i < index; i++) //To loops to fill the new array by skipping the index item.
                {
                    newArray[i] = studentArray[i];
                }
                for (int i = index; i < Length - 1; i++)
                {
                    newArray[i] = studentArray[i + 1];
                }
            }

            studentArray = newArray;
        }

        public void DisplayList()
        {
            int i = 0;
            foreach (var item in studentArray)
            {
                Console.WriteLine("\n (" + i.ToString() + ") " + item.ToString());

                i++;
            }
            Console.WriteLine("\n");
        }


        //Sorting algorithm
        //First parameter : "1" for increasing sorting; "2" for decreasing sorting
        //Seconde parameter "1" to sort by firstname ... "4" to sort by lastname
        public void Sort(int sortDirection, int sortField)
        {
            switch (sortField)
            {
                case 1:
                    Array.Sort(studentArray, delegate (Student x, Student y) { return x.FirstName.CompareTo(y.FirstName); });
                    break;

                case 2:
                    Array.Sort(studentArray, delegate (Student x, Student y) { return x.LastName.CompareTo(y.LastName); });
                    break;

                case 3:
                    Array.Sort(studentArray, delegate (Student x, Student y) { return x.StudentNumber.CompareTo(y.StudentNumber); });
                    break;

                case 4:
                    Array.Sort(studentArray, delegate (Student x, Student y) { return x.AverageScore.CompareTo(y.AverageScore); });
                    break;
            }

            //The list is now sorted in an ascending way. If needed, we sort it in a descending way, by reversing it.
            if (sortField == 2)
            {
                Array.Reverse(studentArray);
            }
        }

        public Student GatMaxElement() //We get the bets scoring student by sorting a copied list.
        {
            Student[] arrayCopy = studentArray;
            Array.Sort(arrayCopy, delegate (Student x, Student y) { return x.AverageScore.CompareTo(y.AverageScore); });
            return (arrayCopy[Length - 1]);
        }

        public Student GatMinElement() //Similar to GetMaxElement()
        {
            Student[] arrayCopy = studentArray;
            Array.Sort(arrayCopy, delegate (Student x, Student y) { return x.AverageScore.CompareTo(y.AverageScore); });
            return (arrayCopy[0]);
        }

        //I could have created a CustomDataList copy and use pre-existing Sorting function and Fist property but it would nneed more ressource.

    }
}

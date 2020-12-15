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

        public void Add(Student newStudent)
        {
            Student[] newArray = new Student[Length + 1];
            for(int i = 0; i<Length; i++)
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
            for(int i = 0; i < Length-1; i++)
            {
                newArray[i] = studentArray[i];
            }
            studentArray = newArray;
        }

        public void RemoveFirst()
        {
            Student[] newArray = new Student[Length - 1];
            for (int i = 0; i < Length-1; i++)
            {
                newArray[i] = studentArray[i+1];
            }
            studentArray = newArray;
        }

        public void RemoveByIndex(int index)
        {
            Student[] newArray = new Student[Length - 1];
            if(index == 0) { RemoveFirst(); }           //We use our previous methods designed for specific cases.
            if(index == Length - 1) { RemoveLast(); }
            else
            {
                for(int i =0; i < index; i++) //To loops to fill the new array by skipping the index item.
                {
                    newArray[i] = studentArray[i];
                }
                for(int i = index; i< Length-1; i++)
                {
                    newArray[i] = studentArray[i + 1];
                }
            }

            studentArray = newArray;
        }
        
        public void DisplayList()
        {
            foreach(var item in studentArray)
            {
                Console.WriteLine("\n" + item.ToString());
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithm_Assignement_1
{
    class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        float averageScore;

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { this.studentNumber = value; }
        }

        public float AverageScore
        {
            get { return averageScore; }
            set { this.averageScore = value; }

        }

        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }

        public override string  ToString() //A little method to make easier displaying the items.
        {
            return firstName + " " + lastName + " N° " + studentNumber + " avg. score : " + averageScore.ToString();
        }

        
    }
}

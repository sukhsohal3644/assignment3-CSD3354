﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
Name - Sukhdeep Sohal student id- c0731586
Name - ankita sharma student id - c0730066
*/
namespace sukhsohal
{
    public delegate void Sort_DataStructure();

    class Program
    {
        static void Main(string[] args) {
            DataStructureQueue dataq = new DataStructureQueue();
            dataq.Run();
            DataStructureQueue datas = new DataStructureQueue();
            datas.Run();
        }
    }
    class Student
    {

        String Student_name;
        String StudentID;
        double StudentGPA;

        // TODO: change this implementation so that the program pulls names from a Text File:
        // to do this, you must change the container for Student Names from Array to List

        String[] names = new String[5] { "Bill", "Mary", "Laura", "Sam", "Steve" };

        Random r1;

        public Student()
        {
            r1 = new Random();
            Student_name = names[r1.Next(0, 4)];
            StudentID = Convert.ToString(r1.Next(1000, 9999));
            StudentGPA = Convert.ToDouble(r1.Next(1, 99));
        }

        public double AverageStudentGPA()
        {
            // TO DO: implement the algorithm to calculate the Students' average GPA
            return 0;
        }
    }

    public interface IDataStructure
    {
        void Sort();
    }

    class DataStructureQueue : IDataStructure
    {
        // the QUEUE holds the classes (that is classroom of students!)
        // TO DO: insert the contents of the Data File: Classroom Data Set 

        public Queue q1 = new Queue();
        Sort_DataStructure Sort1;
        public void Sorter()
        {

            // TO DO : sort the Queue 
            q1.Enqueue("Java - SAT - AM - A202");
            q1.Enqueue("Csharp - MON - PM - B122");
            q1.Enqueue("Math - FRI - AM - A506");
            q1.Enqueue("BigData - THU - B230");
            q1.Enqueue("Java - WED - PM - A202");
            q1.Enqueue("Csharp - THU - PM - B125");
            q1.Enqueue("Math - TUE - AM - B130");
            q1.Enqueue("EmergingTechnologies - FRI - B122");
            q1.Enqueue("MicrosoftDataStack - MON - PM - B122");
            q1.Enqueue("Math - MON - PM - B122");
            q1.Enqueue("Python - FRI - AM - B125");
            q1.Enqueue("JavaEE - FRI - PM - B230");
            q1.Enqueue("SignalProcessing - WED - PM - LAB1");
            q1.Enqueue("EmbeddedProcessor");

        }

        public void Run()
        {
            for (int i = 0; i < 20; i++)
            {

                q1.Enqueue(new Student());

            }
            Sort1 = new Sort_DataStructure(Sorter);
        }
        public void Sort()
        {


        }
    }

    class DataStructureStack : IDataStructure
    {
        // the STACK holds the Students
        public Stack s1 = new Stack();
        Sort_DataStructure Sort1;
        public void Sorter()
        {
            // TO DO : sort the Stack
            s1.Push("Ema");
            s1.Push("Olivia");
            s1.Push("Noah");
            s1.Push("Liam");
            s1.Push("Sophia");
            s1.Push("Mason");
            s1.Push("Ava");
            s1.Push("Jacob");
            s1.Push("William");
            s1.Push("Isabella");
            s1.Push("Ethan");
            s1.Push("Mia");
            s1.Push("James");
            s1.Push("Alexander");

            s1.Pop();

            foreach (Object obj in s1) {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

        public void Run()
        {

            for (int i = 0; i < 20; i++)
            {
               s1.Push(new Student());
            }
            Sort1 = new Sort_DataStructure(Sorter);
        }
        public void Sort() {
        }
    }
}

namespace BubbleSort

{
    class MySort
    {
        static void Main2(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted:");
            foreach (int p in arr)
            Console.Write(p + " ");
            Console.Read();
        }
    }
}

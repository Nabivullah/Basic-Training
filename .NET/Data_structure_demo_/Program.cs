﻿using System;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;

namespace Data_structure_demo
{
    internal class Program
    {


        static void Main(string[] args)
        {//List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine(value: $"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.name);
            }


            //Hashset Example
            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);


            //Queue demo
            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().name);

            // Linked List demo
            Console.WriteLine("Linked List demo");
            LinkedList<Student> students_linkedlist = new LinkedList<Student>();
            students_linkedlist.AddLast(first);
            students_linkedlist.AddLast(second);
            students_linkedlist.AddLast(third);
            foreach (Student student in students_linkedlist)
            {
                Console.WriteLine("Linked list data");
                Console.WriteLine(student.id +". " +student.name);
                //Console.WriteLine(student.name);
            }

            //tuple demo
            Console.WriteLine("Tuple demo");
            Tuple<int, string, int> student_tuple_1 = new Tuple <int, string, int> (1, "Alice", 100);
            Tuple<int, string, int> student_tuple_2 = new Tuple<int, string, int>(2, "Bob", 90);
            Tuple<int, string, int> student_tuple_3 = new Tuple<int, string, int>(3, "Charlie", 80);

            Console.WriteLine(student_tuple_1.Item2 + " Marks:" + student_tuple_1.Item3);
            Console.WriteLine(student_tuple_2.Item2 + " Marks:" + student_tuple_2.Item3);
            Console.WriteLine(student_tuple_3.Item2 + " Marks:" + student_tuple_3.Item3);


        }
    }
}
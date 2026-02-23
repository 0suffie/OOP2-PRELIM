using System;
using System.Collections.Generic;
using System.Data;

namespace DataIMplementand_LISt
{
        
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Course { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                
                DataTable studentTable = new DataTable();
                studentTable.Columns.Add("ID", typeof(int));
                studentTable.Columns.Add("Name", typeof(string));
                studentTable.Columns.Add("Course", typeof(string));

                Console.WriteLine("=== [DATA TABLE SECTION] ===");
                Console.Write("How many students would you like to add to the DataTable? ");
                int dtCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < dtCount; i++) {
                    Console.WriteLine($"\nStudent #{i + 1}:");
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Course: ");
                    string course = Console.ReadLine();

                    
                    studentTable.Rows.Add(id, name, course);
                }

                
                List<Student> studentList = new List<Student>();

                Console.WriteLine("\n\n=== [LIST SECTION] ===");
                Console.Write("How many students would you like to add? ");
                int listCount = int.Parse(Console.ReadLine());

                for (int i = 0; i < listCount; i++){
                    Student newStudent = new Student();

                    Console.WriteLine($"\nStudent #{i + 1}:");
                    Console.Write("Enter ID: ");
                    newStudent.ID = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name: ");
                    newStudent.Name = Console.ReadLine();
                    Console.Write("Enter Course: ");
                    newStudent.Course = Console.ReadLine();

                    
                    studentList.Add(newStudent);
                }

                
                Console.Clear();
                Console.WriteLine("--- SUMMARY OF DATA ENTERED ---\n");

                Console.WriteLine("FROM DATA TABLE:");
                foreach (DataRow row in studentTable.Rows)
                {
                    Console.WriteLine($"[{row["ID"]}] {row["Name"]} - {row["Course"]}");
                }

                Console.WriteLine("\nFROM LIST:");
                foreach (var s in studentList)
                {
                    Console.WriteLine($"[{s.ID}] {s.Name} - {s.Course}");
                }

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
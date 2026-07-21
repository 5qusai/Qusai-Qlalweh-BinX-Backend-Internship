using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {

        public class Student
        {

            public string name;
            private int age;
            public static string degree = "Bachelor";
            private static int counter = 10203040;
            public int id;
            public Student()
            {
                this.name = "Unknown";
                this.age = 20;
                counter++;
                this.id = counter;
            }

            public Student(string name, int age)
            {
                counter++;
                this.id = counter;
                this.age = age;


            }

            public void getInfo()
            {
                Console.WriteLine($"My name is {this.name}");
                Console.WriteLine($"I'am {this.age} years old");
                Console.WriteLine($"With an ID {this.id}");
                Console.WriteLine($"Student With {degree} Degree \n\n");
            }

            public int getAge()
            {
                return age;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

        }

        public class Instructor
        {

            public string name;
            private double salary;
            private static int counter = 11223344;
            public int id;

            public Instructor(string name, double sal)
            {

                salary = sal;
                this.name = name;
                counter++;
                this.id = counter;
            }

            public void getInfo()
            {
                Console.WriteLine($"Instructor Name: {name}");
                Console.WriteLine($"Instructor ID: {id}");
                Console.WriteLine($"Instructor Salary: {salary}$ \n\n");
            }

            public double getSalary()
            {
                return salary;
            }

            public void setSalary(double salary)
            {
                this.salary=salary;
            }
        }
        static void Main(string[] args)
        {


            Student s1=new Student();
            Student s2=new Student("Ahmed",23);
            Student s3=new Student("Qusai",15);

            Instructor I1 = new Instructor("Ala",2900);
            Instructor I2 = new Instructor("Maha",1900);
            Instructor I3 = new Instructor("Saed",3400);

            I2.setSalary(5000);

            s1.getInfo();
            s2.getInfo();
            s3.getInfo();

            I1.getInfo();
            I2.getInfo();
            I3.getInfo();
        }
    }
}

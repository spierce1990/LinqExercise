﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum");

            var newSum = numbers.Sum(x => x); Console.WriteLine(newSum);


            //TODO: Print the Average of numbers

            Console.WriteLine("Average");

            var newAverage = numbers.Average(x => x); Console.WriteLine(newAverage);

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Order by ascending");


            var newOrder = numbers.OrderBy(x => x); foreach (var item in newOrder) Console.WriteLine(item);

            //TODO: Order numbers in decsending order and print to the console


            Console.WriteLine("Descending");


            var newDes = numbers.OrderByDescending(x => x); foreach (var item in newDes) Console.WriteLine(item);




            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Greater than 6:");

            var greaterThanSix = numbers.Where(x => x > 6); foreach (var item in greaterThanSix) Console.WriteLine(item);

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("only four:");

            foreach (var item in numbers.OrderBy(x => x).Take(4))
            {
                Console.WriteLine(item);
            }

            //var onlyFour =  numbers.OrderBy(x => x );numbers.Count == 4; foreach (var item in onlyFour) ; Console.WriteLine(item);

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending ordernumbers[]



            Console.WriteLine("Items with Age");
            numbers[4] = 32;
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //IF I WAS TO USE LINQ CODE WOULD BE numbers.SetValue(32, 4);

            Console.WriteLine("Items with Age and order descending");
            //printede with new value
            var ageAdded = numbers.OrderByDescending
                 (x => x); foreach (var item in ageAdded) Console.WriteLine(item);
            //

            Console.WriteLine("Next Section");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            employees.Where(x => x.FirstName.StartsWith("C") || x.FirstName.StartsWith("S")).OrderBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine(x.FullName));

            Console.WriteLine("Print order by age and name");
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).OrderBy(x => x.FirstName).ToList()
                .ForEach(x => Console.WriteLine($"{x.Age}, {x.FullName}"));

            Console.WriteLine("Printing sum and Average:");
            int sum = employees.Where(x => x.Age > 35 && x.YearsOfExperience >= 10).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sum);


            double average = employees.Where(x => x.YearsOfExperience >= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(Math.Round(average));


            employees.Append(new Employee("Sionylen", "Pierce", 21, 10));




            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

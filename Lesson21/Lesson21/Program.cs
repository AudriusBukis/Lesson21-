using Lesson21.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 21 linq and lambda");

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();

            Task8();
            Console.WriteLine("begemotas miske");
            var listOfWordsUpperCasse = Task9("begemotas is miske ATEJO ir isejo bei UZMIGO");
            Console.WriteLine();
            foreach (var item in listOfWordsUpperCasse)
            {
                Console.WriteLine(item);
            }
            
        }
        static void Task1()
        {
            var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newList = intList.Select(integer => Math.Pow(integer, 2));
        }
        static void Task2()
        {
            var intList = new List<int>() { 1, -2, 3, 4, 5, -6, 7, 8, 9, -10, 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            var newList = intList.Where(integer => integer >= 0);
        }
        static void Task3()
        {
            var intList = new List<int>() { 1, -2, 3, 15, 5, -6, 7, 20, 9, -10, 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            var newList = intList.Where(integer => integer >= 0).
                                  Where(integer => integer < 10);
        }
        static void Task4()
        {
            var intList = new List<int>() { 1, -2, 3, 15, 5, -6, 7, 20, 9, -10, 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            var newList = intList.OrderBy(integer => integer);
        }
        static void Task5()
        {
            var intList = new List<int>() { 1, -2, 3, 15, 5, -6, 7, 20, 9, -10, 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            var newList = intList.OrderByDescending(integer => integer);
        }
        static void Task6()
        {
            var intList = new List<int>() { 1, -2, 3, 15, 5, -6, 7, 20, 9, -10, 1, 2, 3, -4, 5, 6, -7, 8, -9, 10 };
            var newList = intList.OrderBy(integer => integer).Last();
        }

        static void Task7()
        {
            var personList = new List<Person>();
            personList.Add(new Person(36, "Audrius"));
            personList.Add(new Person(12, "Tadas"));
            personList.Add(new Person(18, "Marius"));
            personList.Add(new Person(66, "Pranas"));
            personList.Add(new Person(86, "Antanas"));
            personList.Add(new Person(55, "Gytis"));
            personList.Add(new Person(6, "Mindaugas"));
            personList.Add(new Person(25, "Andrius"));

            var listNames = personList.Select(person => person.Name).ToList();

            var listAges = personList.Select(person => person.Age).ToList();

            var sortedPersonListByAge = personList.OrderByDescending(person => person.Age);

            var newListPersonNameStartWithA = personList.Where(person => person.Name.StartsWith("A"));

            var newListPersonOlderThen40 = personList.Where(person => person.Age > 40).
                                                      OrderBy(person => person.Name);

        }
        static void Task8()
        {
            var personList = new List<Person>();
            personList.Add(new Person(36, "Audrius"));
            personList[0].Pets.Add(new Pets("Muskis", 5));
            personList[0].Pets.Add(new Pets("Kicius", 6));
            personList.Add(new Person(12, "Tadas"));
            personList[1].Pets.Add(new Pets("Amsius", 5));
            personList[1].Pets.Add(new Pets("Brisius", 9));
            personList[1].Pets.Add(new Pets("Bobis", 3));
            personList.Add(new Person(18, "Marius"));
            personList[2].Pets.Add(new Pets("Mobsis", 1));
            personList.Add(new Person(66, "Pranas"));
            personList[3].Pets.Add(new Pets("Cypsius", 6));
            personList[3].Pets.Add(new Pets("Kvyksius", 2));
            personList.Add(new Person(86, "Antanas"));
            personList[4].Pets.Add(new Pets("Bagira", 15));
            personList.Add(new Person(55, "Gytis"));
            personList[5].Pets.Add(new Pets("Margis", 13));
            personList[5].Pets.Add(new Pets("Tobis", 5));
            personList.Add(new Person(6, "Mindaugas"));
            personList[6].Pets.Add(new Pets("Dange", 7));
            personList.Add(new Person(25, "Andrius"));
            personList[7].Pets.Add(new Pets("Bobis", 6));
            personList[7].Pets.Add(new Pets("Rokis", 9));
            personList[7].Pets.Add(new Pets("Juodis", 16));

            var petsNameBeginsWithA = personList.SelectMany(person => person.Pets).
                                                 Where(pet => pet.Name.StartsWith("A")).ToList();
            Console.WriteLine();
            foreach (var pets in petsNameBeginsWithA)
            {
                Console.WriteLine($"{pets.Name} age {pets.Age}");
            }
            Console.WriteLine();
            var petsNameBeginsWithBOderThen5 = personList.SelectMany(person => person.Pets).
                                                          Where(pet => pet.Name.StartsWith("B")).
                                                          Where(pet => pet.Age > 5).ToList();

            foreach (var pets in petsNameBeginsWithBOderThen5)
            {
                Console.WriteLine($"{pets.Name} age {pets.Age}");
            }
            Console.WriteLine();

        }
        static List<string> Task9(string str)
        {
            return str.Split(' ', ',', '.', '?').
                       Where(x => String.Equals(x, x.ToUpper())).ToList();
        }
    }
}

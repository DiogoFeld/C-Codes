﻿using System.Collections.Generic;

namespace RandomCodes
{
    public static class SwitchExpression
    {
        //Matching specific values, similar to traditional case statements:
        public static string GetCategory(int number) => number switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => "Other" // Default case
        };

        //Using ranges instead of listing out every possible value:
        public static string GetGrade(int score) => score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        public static string DescribeObject(object obj) => obj switch
        {
            int n => $"It's an integer: {n}",
            string s => $"It's a string: {s}",
            bool b => $"It's a boolean: {b}",
            _ => "Unknown type"
        };

        public static string WeatherAdvice(string weather, bool isWeekend) => (weather, isWeekend) switch
        {
            ("Sunny", true) => "Go to the beach!",
            ("Sunny", false) => "Enjoy a walk after work.",
            ("Rainy", _) => "Stay inside and read a book.",
            _ => "Just another day."
        };

        public static string GetDiscount(Person person) => person switch
        {
            { Age: < 12 } => "Child discount",
            { Age: >= 65 } => "Senior discount",
            _ => "Regular price"
        };

        public static string GetIdade(int anos) => anos switch
        {
            <= 3 => "bebe",
            <= 12 => "crianca",
            <= 18 => "adolescente",
            <= 60 => "adulto",
            _ => "idoso"
        };


    }

    public class Person
    {
        public string Name { get; set; }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value < 120)
                {
                    _age = value;
                }
            }
        }
        private int _age;


        public string Info
        {
            get
            {
                {
                    return $"meu nome é {this.Name} e tenho {this.Age} anos";
                }
            }

        }



 




    }
    
}

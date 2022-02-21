using System;

namespace Lesson21.Models
{
    public class Pets
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Pets(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}

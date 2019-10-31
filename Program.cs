using System;
using System.Collections.Generic;

namespace Repka
{
    class Program
    {
        static void Main(string[] args)
        {
            char? c;
            List<Person> Line = new List<Person>();

            do
            {
                Console.Clear();
                Console.WriteLine("Добавить персонажа в цепочку - нажмите 'a'");
                Console.WriteLine("Тащить репку - нажмите 's'");
                Console.WriteLine("Для окончания - нажмите 'q'");
                Console.WriteLine("Репку могут вытащить только 3 персонажа!");
                Console.WriteLine($"Количество персонажей в цепочке: {Line.Count}");
                c = Convert.ToChar(Console.ReadLine());

                switch (c)
                {
                    case 'a':
                        Line.Add(new Person() { Name = "Person" + (Line.Count + 1) });
                        break;
                    case 's':
                        if (Line.Count < 3)
                        {
                            Console.WriteLine("Недостаточно персонажей в цепочке, чтобы вытащить репку!");
                            c = null;
                        }
                        else
                        {
                            Console.WriteLine("Репка вытащена!");
                            c = 'q';
                        }
                        Console.Read();
                        break;
                }
            }
            while (c != 'q');
        }

    }

    class Person
    {
        public string Name;
        public void Display()
        {
            Console.WriteLine(Name);
        }

   
    }
}

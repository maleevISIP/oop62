using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop62
{
    
        class String
        {
            private string Line;

            public String()
            {
                Line = "Пусто";
            }

            public String(string Line)
            {
                if (Line.Length > 10)
                    this.Line = "Слишком длинная строка";
                else
                    this.Line = Line;
            }

            public void Display()
            {
                Console.WriteLine(Line);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                String st = new String();
                st.Display();
                String stOne = new String("12345678910");
                stOne.Display();
                String stTwo = new String("123");
                stTwo.Display();

                Console.ReadKey();
            }
        }
    }

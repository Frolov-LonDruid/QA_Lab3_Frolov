using System;

namespace Csharp3._9._5
{
    class Program
    {
        public class Zdanie
        {
            private int plosh;
            private double tsena;
            public void Init(int v, double t)
            {
                plosh = v;
                tsena = t;
            } // метод инициализации
            public void Read()
            {
                string s = "";
                s = Console.ReadLine();
                string[] s1;
                s1 = s.Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
                plosh = Convert.ToInt32(s1[0]);
                tsena = Convert.ToInt32(s1[1]);

            }
            public double Cost()
            {
                double cost = plosh * tsena;
                return cost;
            }
            public void Display()
            {
                Console.WriteLine("Площадь здания: " + plosh + "\nЦена за квадратный метр: " + tsena);
            }
        }

        public class Predpriyatie
        {
            private Zdanie e1 = new Zdanie();
            private Zdanie e2 = new Zdanie();
            private Zdanie e3 = new Zdanie(); // локальные переменные типа Element
            public string name;
            public void Init(String name, int v1, double t1, int v2, double t2, int v3, double t3)
            {
                this.name = name;
                e1.Init(v1, t1);
                e2.Init(v2, t2);
                e3.Init(v3, t3);
            }  // метод инициализации
            public void Read(int i)
            {
                switch (i)
                {
                    case 1: { e1.Read(); break; }
                    case 2: { e2.Read(); break; }
                    case 3: { e3.Read(); break; }
                }
            }
            public double Cost()
            {
                double cost = e1.Cost() + e2.Cost() + e3.Cost();
                Console.WriteLine("\nСтоимость здания-1:" + e1.Cost());
                Console.WriteLine("\nСтоимость здания-2:" + e2.Cost());
                Console.WriteLine("\nСтоимость здания-3:" + e3.Cost());
                return cost;
            }
            public void Display()
            {
                Console.WriteLine(name);
                Console.WriteLine("Здание-1:");
                e1.Display();
                Console.WriteLine("Здание-2:");
                e2.Display();
                Console.WriteLine("Здание-3");
                e3.Display();
            }
            public Zdanie Expensive()
            {
                double a = e1.Cost();
                double b = e2.Cost();
                double c = e3.Cost();
                if (a >= b && a >= c) return e1;
                if (b > a && b > c) return e2;
                if (c > a && c > b) return e3;
                return null;
            }
        }
        static void Main(string[] args)
        {
            Predpriyatie chair = new Predpriyatie();
            chair.Init("as wggwerg ggwregwag ds gwgqsfer ", 123, 764, 1265, 100, 634, 13);

            string str1 = "", str2 = "";
            int k = 0; int r = 0;
            string str = chair.name;

            for (int i = 0;
                i < str.Length; i++)
            {
                while (str[i] != ' ') { k = k + 1; i = i + 1;  r = i; }

                str2 = "";

                if (k >= 3)
                {
                    str2 = str.Substring(r - k, k);
                    k = 0;
                    if ((str2[2] == 'w') || (str2[2] == 'e') || (str2[2] == 'r'))
                    {
                        if ((str2[3] == 'w') || (str2[3] == 'e') || (str2[3] == 'r'))
                        {
                            if ((str2[4] == 'w') || (str2[4] == 'e') || (str2[4] == 'r'))
                            {
                                i = r;
                            }
                            else { str1 = str1 + str2 + " "; i = r; }
                        }
                        else { str1 = str1 + str2 + " "; i = r; }
                    }
                    else { str1 = str1 + str2 + " "; i = r; }
                }
                else
                {
                    str2 = str.Substring(r-2, 2);
                    str1 = str1 + str2 + " ";
                    str2 = "";
                    k = 0;
                    i = r;
                }
            }
            chair.name = str1;
            chair.Display(); // вывод значени
            Console.WriteLine("Общая стоимость: " + chair.Cost());
            Zdanie expensive = chair.Expensive();
            Console.WriteLine("Дорогое здание:");
            expensive.Display();
            Console.WriteLine("Наибольшая стоимость: " + expensive.Cost());
        }

    }
}
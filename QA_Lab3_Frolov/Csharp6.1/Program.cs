using System;

namespace Csharp6._1
{
    /// <summary>
    /// <brief>Базовый класс "Комплексное число"</brief>
    /// Данный класс нужен для хранения и обработки информации о комплексном числе
    /// </summary>
    class Complex
    {
        protected int re;// мнимая часть
        protected int im;// вещественная часть
        /// <summary>
        /// Конструктор класса Complex, инициализирующий переменные
        /// </summary>
        /// <param name="re">мнимая часть</param>
        /// <param name="im">вещественная часть</param>
        public void Init(int valueRe, int valueIm)
        {
            this.re = valueRe;
            this.im = valueIm;
        }
        /// <summary>
        /// <brief>Базовый объекты класса "Комплексное число"</brief>
        /// </summary>
        public Complex(int re, int im)
        {
            this.re = re;
            this.im = im;
        }

        public Complex()
        {
            this.re = 5;
            this.im = -9;
        }
        /// <summary>
        /// Отображает комплексное число
        /// </summary>
        public void Display()
        {
            if (im > 0)
            {
                Console.WriteLine("комплексное число(z)= (" + re + " + " + im + "i)");
            }
            else
            {
                int tt = im * (-1);
                Console.WriteLine("комплексное число(z)= (" + re + " - " + tt + "i)");
            }
        }
        /// <summary>
        /// Вычисляет модуль комплексного числа
        /// </summary>
        public float Modul()
        {
            float zd = (float)Math.Sqrt(re * re + im * im);
            return zd;
        }
    };
    /// <summary>
    /// <brief>Производный класс "Пространственные комплексные числа"</brief>
    /// Обычный дочерний класс, который отнаследован от ранее созданного класса Complex
    /// </summary>

    class openComplex :Complex // наследование
    {
        //a. В производном классе добавляется указанное поле private
        private float Z; // координата Z

        /// <summary>
        /// Конструктор класса Complex, инициализирующий переменные
        /// </summary>
        public void Init(int re, int im, float z)//d. Выполняется перегрузка функций Init, Display для производного класса с вызовом функции базового класса.
        {
            base.Init(re, im);
            this.Z = base.Modul();
        }
        /// <summary>
        /// Отображает комплексные числа
        /// </summary>
        public void Display()//d. Выполняется перегрузка функции Display для производного класса с вызовом функции базового класса.
        {
            base.Display();
            Console.WriteLine("переменная наследуемого класса " + Z);
        }

        /// <summary>
        /// <brief>Базовый объекты класса "Пространственные комплексные числа"</brief>
        /// </summary>
        public openComplex(int re, int im, float z) : base(re, im)
        {
            this.Z = z;
        }
    };
    /// <summary>
    /// <brief>Класс "Program"</brief>
    /// Данный класс нужен для исполнения кода
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            openComplex ab = new openComplex(5, 7, 8);//e. В базовом и производном классах создать конструкторы с параметрами.Продемонстрировать в конструкторе производного класса с параметрами вызов конструктора базового класса.
            ab.Display();
            ab.Display();;
        }
    }

}

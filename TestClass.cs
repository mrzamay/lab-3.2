using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInput
{
    /// <summary>
    /// Тестовый класс
    /// с контролем значения, присваиваемому параметру b.
    /// </summary>
    public class TestClass
    {
        //Объявление полей
        public double b = 0;


        //private int _a = 1;
        /*public int a
        {
            get { return _a; }
            set
            {   
                if (value == 1) //Генерируем исключение - нулевые значения запрещены!
                    throw new Exception("Значение a равное единице недопустимо!");
                else
                    _a = value;
            }
        }*/
        public int a = 1;


        public double[,] data = new double[5,4];


        public double Calc()
        {
            return a+b*b/(a-1);
        }
    }

    public class Clac2 : TestClass
    {
        public double d = 1;

        public double getAnsw()
        {
            if (d < a) return a + b + d;
            else return a - b - d;
        }
    }
}

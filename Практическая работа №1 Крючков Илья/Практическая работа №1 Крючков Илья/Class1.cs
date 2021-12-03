using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{
    class Class1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="k"></param>
        /// <param name="kol"></param>
        /// <param name="h2"></param>
        /// <param name="h1"></param>

        public static void Sum(int k, out int kol, out string h2, out string h1)//Считает сумму
        {
            int x;// сгенерированное число
            int sum = 0;// сумма
            kol = 0;// количество сгенерированных чисел
            Random rnd = new Random();
            h1 = "";// строка для вывода суммы
            h2 = "";// строка для вывода сгенерированных чисел

            while (sum > k)// пока сумма больше к
            {
                x = rnd.Next(-7, 3);// генерирование чисел, распределенных в диапазоне от -7 до 3
                h2 += Convert.ToString(x) + " ";
                kol++;// счетчик количества чисел
                sum = sum + x;// вычисление суммы    
            }
            h1 = Convert.ToString(sum);

        }
    }
}

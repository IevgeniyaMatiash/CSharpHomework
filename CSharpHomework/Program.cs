using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить среднее арифметическое значений в диапазоне n – m включительно.
            {
                int n = 45, m = 91;
                int sum = 0;
                int count = 0;
                for (int i = n; i <= m; i++)
                {
                    sum += i;
                    ++count;
                }
                double average = sum / count;
            }

            //Написать код определения суммы четных чисел в диапазоне целых значений 0 – n1, 
            //используя только операторы повторения (использование if запрещено).
            {
                int n1 = 8;
                int sum = 0;
                for (int i = 0; i <= n1; i+=2)
                {
                    sum += i;
                }
            }
            //Написать код определения суммы четных чисел в диапазоне целых значений n1 – n2, 
            //используя условные операторы if и операторы повторения.
            {
                int n1 = 5;
                int n2 = 11;
                int sum = 0;

                if (n1<n2)
                {
                    if (n1 % 2 == 0)
                    {
                        for (int i = n1; i <= n2; i += 2)
                        {
                            sum += i;
                        }
                    }
                    else 
                    {
                        n1 += 1;
                        for (int i = n1; i <= n2; i += 2)
                        {
                            sum += i;
                        }
                    }
                }
                else 
                {
                    if (n2 % 2 == 0)
                    {
                        for (int i = n2; i <= n1; i += 2)
                        {
                            sum += i;
                        }
                    }
                    else
                    {
                        n2 += 1;
                        for (int i = n2; i <= n1; i += 2)
                        {
                            sum += i;
                        }
                    }
                }

            }
        }

    }
}

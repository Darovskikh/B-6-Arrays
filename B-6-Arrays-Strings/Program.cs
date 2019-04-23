using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        public static int[] array = new int[5];
        static void Main(string[] args)
        {
            //MassiveMaxInRow();
            //ReadMassive();
            Pyatnashki();
            //CutString();
            //ReplaceInPoem();
            Console.ReadLine();
        }

        public static void WriteArray(int[,] a)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{a[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        public static void Pyatnashki()
        {
            Random random = new Random();
            int[,] a =
            {
                {14, 9, 3, 2},
                {
                    1, 0, 5, 10
                },
                {
                    13, 15, 4, 7
                },
                {
                    6, 8, 11, 12
                }
            };

            WriteArray(a);
            int l = 1, r = 1;
            Console.WriteLine("Для управления используйте WASD");          
            ConsoleKeyInfo cki= new ConsoleKeyInfo();
           
            while (true)
            {               
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.W:
                        if (l == 0)
                        {
                            Console.WriteLine();
                            WriteArray(a);
                            break;
                        }
                        int b = a[l, r];
                        a[l, r] = a[--l, r];
                        a[l, r] = b;                        
                        Console.WriteLine();
                        WriteArray(a);
                        break;
                    case ConsoleKey.A:
                        if (r == 0)
                        {
                            Console.WriteLine();
                            WriteArray(a);
                            break;
                        }
                        int c = a[l, r];
                        a[l, r] = a[l,--r];
                        a[l , r] = c;
                        Console.WriteLine();
                        WriteArray(a);
                        break;
                    case ConsoleKey.S:
                        if (l == 3)
                        {
                            Console.WriteLine();
                            WriteArray(a);
                            break;
                        }
                        int x = a[l, r];
                        a[l, r] = a[++l, r];
                        a[l, r] = x;
                        Console.WriteLine();
                        WriteArray(a);
                        break;
                    case ConsoleKey.D:
                        if (r == 3)
                        {
                            Console.WriteLine();
                            WriteArray(a);
                            break;
                        }
                        int z = a[l, r];
                        a[l, r] = a[l, ++r];
                        a[l, r] = z;
                        Console.WriteLine();
                        WriteArray(a);
                        break;                        
                }                               
            }
        }


        public static void MassiveMaxInRow()
        {
            Random random = new Random();
            int[,] array = new int[,]
            {
                {random.Next(1000), random.Next(1000), random.Next(1000)},
                {
                    random.Next(1000), random.Next(1000), random.Next(1000)
                },
                {
                    random.Next(1000), random.Next(1000), random.Next(1000)
                }
            };
            for (int i = 0; i < 3; i++)
            {
                int maxFirst = Int32.MinValue;
                for (int j = 0; j < 3; j++)
                {                    
                    if (array[i, j] > maxFirst)
                    {
                        maxFirst = array[i, j];
                    }
                }

                Console.WriteLine($"Максимум в {i} строке - {maxFirst.ToString()}");
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]+" ");
                }

                Console.WriteLine();
            }
        }
        
        public static void ReadMassive()
        {
            
            Console.WriteLine("Введите пять чилсел");
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            QSort(0, array.Length-1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        public static void QSort(int i, int j)
        {
            int b = i, e = j;
            int op = array[(b + e )/ 2];
            while (b <= e)
            {
                while (array[b] < op)
                {
                    b++;
                }

                while (array[e] > op)
                {
                    e--;
                }

                if (b <= e)
                {
                    int z = array[b];
                    array[b] = array[e];
                    array[e] = z;
                    b++;
                    e--;
                }
            }

            if (i < e)
            {
                QSort(i, e);
            }

            if (j > b)
            {
                QSort(b, j);
            }
            
        }

        public static void CutString()
        {
            Console.WriteLine("Введите предложение");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Количество символов равно - {sentence.Length}");
            if (sentence.Length > 13)
            {
                sentence = sentence.Remove(13);
                sentence = sentence + "...";                
            }
            Console.WriteLine(sentence);
        }

        public static void ReplaceInPoem()
        {
            Console.WriteLine("Введите стих разделяя строки точкой с запятой");
            string poem = Console.ReadLine();
            poem = poem.ToUpper();
            string[] p = poem.Split(';');
            foreach (string str in p)
            {
                string st = str.Replace('О', 'А');
                string s = st.Replace("Л", "ЛЬ");
                string s1 = s.Replace("ТЬ", "Т");
                Console.WriteLine(s1);
            }

        }
        public static void PoemExample()
        {
            
        }
    }
}

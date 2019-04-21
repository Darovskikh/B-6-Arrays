using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MassiveMaxInRow();
            Console.ReadLine();
        }

        public static void Pyatnashki()
        {
      
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
    
      
        public static void PoemExample()
        {
            
        }
    }
}

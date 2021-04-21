using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level_6
{
    class HomeWork
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();
            string[,] sArray = new string[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sArray[i, j] = random.Next(1, 50).ToString();
                }
            }

            sArray[2, 3] = " ";

            try
            {
                sum = sumArray(sArray);
            }
            catch (ArraySizeExeption e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (ArrayDataException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);

        }






            public static int sumArray(string[,] sArray)
            {
                int sum = 0;
                if (sArray.GetLength(0) != 4) throw new ArraySizeExeption();
                for (int i = 0; i < sArray.GetLength(0); i++)
                {
                    for (int j = 0; j < sArray.GetLength(1); j++)
                    {
                        try
                        {
                            sum += Int32.Parse(sArray[i, j]);
                        }
                        catch (Exception)
                        {
                            throw new ArrayDataException(i, j);
                        }

                    }
                }
                return sum;
            }
    }
}

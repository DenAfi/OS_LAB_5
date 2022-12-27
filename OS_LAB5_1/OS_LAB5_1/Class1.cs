using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OS_LAB5_1
{
   
    
    class Class_Tasks
    {
        /*public static void Mas_Init(int[,] arr, ref int sum)
        {
            int size = arr.GetLength(0);
            Thread.Sleep(1000);

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = rand.Next(0, 101);
                    sum = sum + arr[i, j];
                }
            }
        }
        */
        private static int Call = 0;
        private static Mutex mtx = new Mutex();
        public static void Mas_Init(object arg)
        {
            Thread CurrentThread = Thread.CurrentThread;
            Headache h = arg as Headache;
            int size = h.arr.GetLength(0);
            h.ThreadID = CurrentThread.ManagedThreadId.ToString();

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Thread.Sleep(1000);
                    h.arr[i, j] = rand.Next(0, 101);
                    h.sum = h.sum + h.arr[i, j];
                }
            }
        }

        /*public static void Rev_Mas_Find(ref int[,] arr, ref int sum)
        {
            int size = arr.GetLength(0);           
            Thread.Sleep(1000);
            int[,] arr_ch = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr_ch[j, i] = arr[i, j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = arr_ch[i, j];
                    sum = arr[i, j];
                }
            }
        }
        */
        public static void Rev_Mas_Find(object arg)
        {
            Thread CurrentThread = Thread.CurrentThread;
            Headache h = arg as Headache;
            int size = h.arr.GetLength(0);
            h.ThreadID = CurrentThread.ManagedThreadId.ToString();
            int[,] arr_ch = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //Thread.Sleep(1000);
                    arr_ch[j, i] = h.arr[i, j];
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Thread.Sleep(1000);
                    h.arr[i, j] = arr_ch[i, j];
                    h.sum = h.arr[i, j];
                }
            }
        }
        

        public static void Mananger(object arg)
        {
            
            mtx.WaitOne();
            if (Call % 2 == 0)
            {
                Call++;
                Mas_Init(arg);
            }
            else
            {
                Call++;
                Rev_Mas_Find(arg);
            }
            mtx.ReleaseMutex();
        }
        public static void Null_Arr(ref int[,] arr)
        {
            int size = arr.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[i, j] = 0;
                }
            }
        }
    }
}

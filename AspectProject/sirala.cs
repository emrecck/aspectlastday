using PostSharp.Aspects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class sirala
    {
        public string[] Siralaturegore(MethodExecutionArgs args)
        {
            if (args.ReturnValue.GetType() == typeof(List<int>))
            {

                List<int> list_ = (List<int>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in array)
                {
                    Console.Write(item + " , ");
                }
                Console.WriteLine("\n Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(List<string>))
            {
                List<string> list_ = (List<string>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i];
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(List<double>))
            {
                List<double> list_ = (List<double>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(List<float>))
            {
                List<float> list_ = (List<float>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(List<decimal>))
            {
                List<decimal> list_ = (List<decimal>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(List<long>))
            {
                List<long> list_ = (List<long>)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(ArrayList))
            {
                ArrayList list_ = (ArrayList)args.ReturnValue;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(int[]))
            {
                int[] list_ = (int[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(string[]))
            {
                string[] list_ = (string[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i];
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(double[]))
            {
                double[] list_ = (double[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(float[]))
            {
                float[] list_ = (float[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(decimal[]))
            {
                decimal[] list_ = (decimal[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.ReturnValue.GetType() == typeof(long[]))
            {
                long[] list_ = (long[])args.ReturnValue;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else
                return new string[0];


        }

    }
}

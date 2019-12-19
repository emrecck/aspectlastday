using PostSharp.Aspects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class siralaPropetry
    {
        public ICollection Siralaturegore(LocationInterceptionArgs args)
        {
            if (args.Value.GetType() == typeof(List<int>))
            {
                List<int> list_ = (List<int>)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(List<string>))
            {
                List<string> list_ = (List<string>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                return list_;
            }
            else if (args.Value.GetType() == typeof(List<double>))
            {
                List<double> list_ = (List<double>)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(List<float>))
            {
                List<float> list_ = (List<float>)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(List<decimal>))
            {
                List<decimal> list_ = (List<decimal>)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(List<long>))
            {
                List<long> list_ = (List<long>)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(ArrayList))
            {
                ArrayList list_ = (ArrayList)args.Value;
                list_.Sort();
                return list_;
            }
            else if (args.Value.GetType() == typeof(int[]))
            {
                int[] list_ = (int[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else if (args.Value.GetType() == typeof(string[]))
            {
                string[] list_ = (string[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else if (args.Value.GetType() == typeof(double[]))
            {
                double[] list_ = (double[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else if (args.Value.GetType() == typeof(float[]))
            {
                float[] list_ = (float[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else if (args.Value.GetType() == typeof(decimal[]))
            {
                decimal[] list_ = (decimal[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else if (args.Value.GetType() == typeof(long[]))
            {
                long[] list_ = (long[])args.Value;
                Array.Sort(list_);
                return list_;
            }
            else
                return new string[0];
        }

    }
}

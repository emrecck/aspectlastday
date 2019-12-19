using PostSharp.Aspects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class sirala
    {
        public ICollection Siralaturegore(MethodExecutionArgs args)
        {
            if (args.ReturnValue.GetType() == typeof(List<int>))
            {
                var parameters = args.Arguments[1];
                List<int> list_ = (List<int>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(List<string>))
            {
                var parameters = args.Arguments[1];
                List<string> list_ = (List<string>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(List<double>))
            {
                var parameters = args.Arguments[1];
                List<double> list_ = (List<double>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(List<float>))
            {
                var parameters = args.Arguments[1];
                List<float> list_ = (List<float>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }
                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(List<decimal>))
            {
                var parameters = args.Arguments[1];
                List<decimal> list_ = (List<decimal>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(List<long>))
            {
                var parameters = args.Arguments[1];
                List<long> list_ = (List<long>)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(ArrayList))
            {
                var parameters = args.Arguments[1];
                ArrayList list_ = (ArrayList)args.ReturnValue;
                if (parameters == "asc")
                {
                    list_.Sort();
                }
                else if (parameters == "desc")
                {
                    list_.Sort();
                    list_.Reverse();
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    list_.Sort();
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(int[]))
            {
                var parameters = args.Arguments[1];
                int[] list_ = (int[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }
                Array.Sort(list_);

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(string[]))
            {
                var parameters = args.Arguments[1];
                string[] list_ = (string[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(double[]))
            {
                var parameters = args.Arguments[1];
                double[] list_ = (double[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(float[]))
            {
                var parameters = args.Arguments[1];
                float[] list_ = (float[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(decimal[]))
            {
                var parameters = args.Arguments[1];
                decimal[] list_ = (decimal[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }

                return list_;
            }
            else if (args.ReturnValue.GetType() == typeof(long[]))
            {
                var parameters = args.Arguments[1];
                long[] list_ = (long[])args.ReturnValue;
                if (parameters == "asc")
                {
                    Array.Sort(list_);
                }
                else if (parameters == "desc")
                {
                    Array.Sort(list_);
                    Array.Reverse(list_);
                }
                else
                {
                    Console.WriteLine("buyukten kucuge sıralamak istiyorsanız ; desc kucukten buyuge siralamak istiyorsaniz asc degeri giriniz");
                    Array.Sort(list_);
                }

                return list_;
            }
            else
                return new string[0];
        }
    }
}

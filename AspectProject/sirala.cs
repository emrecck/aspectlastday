using PostSharp.Aspects;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    public class sirala
    {
        public ICollection Siralaturegore(MethodExecutionArgs args,string siralagirdi)
        {
            if (args.ReturnValue.GetType() == typeof(List<int>))
            {
                
                
                List<int> list_ = (List<int>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                List<string> list_ = (List<string>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                List<double> list_ = (List<double>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                List<float> list_ = (List<float>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                List<decimal> list_ = (List<decimal>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                List<long> list_ = (List<long>)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                ArrayList list_ = (ArrayList)args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    list_.Sort();
                }
                else if (siralagirdi == "desc")
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
                
                int[] list_ = (int[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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
                
                string[] list_ = (string[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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
                
                double[] list_ = (double[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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
                
                float[] list_ = (float[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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
                
                decimal[] list_ = (decimal[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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
                
                long[] list_ = (long[])args.ReturnValue;
                if (siralagirdi == "asc")
                {
                    Array.Sort(list_);
                }
                else if (siralagirdi == "desc")
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

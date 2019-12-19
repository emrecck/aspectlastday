using ConsoleApp3;
using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> array = new List<int>() { 15, 9, 8, 54, 45, 2, 67, 15, 68 };
            //MyClass MyObject = new MyClass();
            //MyObject.MyMethodI(array);


            int[] dizim = new int[] { 3, 2, 5, 8 };
            var customer = new Customer(dizim);
            int count = 0;
            foreach (int element in customer.Address)
            {

                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }

            //Console.WriteLine("Name: {0}", customer.Name);

            Console.ReadLine();

        }
    }

    [Serializable]
    public class MyAsepctClass : OnMethodBoundaryAspect
    {
        //public override void OnEntry(MethodExecutionArgs args)
        //{
        //    Console.WriteLine("before the method");
        //}
        public override void OnSuccess(MethodExecutionArgs args)
        {
            if (args.ReturnValue is ICollection)
            {
                sirala mysirala = new sirala();
                mysirala.Siralaturegore(args);

            }
            else Console.WriteLine("Collection degil");
        }

    }

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

    public class siralaPropetry
    {
        public string[] Siralaturegore(LocationInterceptionArgs args)
        {
            if (args.Value.GetType() == typeof(List<int>))
            {

                List<int> list_ = (List<int>)args.Value;
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
                //Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(List<string>))
            {
                List<string> list_ = (List<string>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i];
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(List<double>))
            {
                List<double> list_ = (List<double>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(List<float>))
            {
                List<float> list_ = (List<float>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(List<decimal>))
            {
                List<decimal> list_ = (List<decimal>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(List<long>))
            {
                List<long> list_ = (List<long>)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(ArrayList))
            {
                ArrayList list_ = (ArrayList)args.Value;
                list_.Sort();
                string[] array = new string[list_.Count];
                for (int i = 0; i < list_.Count; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(int[]))
            {
                int[] list_ = (int[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(string[]))
            {
                string[] list_ = (string[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i];
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(double[]))
            {
                double[] list_ = (double[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(float[]))
            {
                float[] list_ = (float[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(decimal[]))
            {
                decimal[] list_ = (decimal[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else if (args.Value.GetType() == typeof(long[]))
            {
                long[] list_ = (long[])args.Value;
                Array.Sort(list_);
                string[] array = new string[list_.Length];
                for (int i = 0; i < list_.Length; i++)
                {
                    array[i] = list_[i].ToString();
                }
                foreach (var item in list_)
                {
                    // Console.Write(item + " ");
                }
                // Console.WriteLine("\n" + "Sorted");
                return array;
            }
            else
                return new string[0];


        }

    }

    public class MyClass
    {
        [MyAsepctClass]
        public List<int> MyMethodI(List<int> array)
        {
            return array;
        }
        [MyAsepctClass]
        public List<string> MyMethodS(List<string> array)
        {
            return array;
        }
        [MyAsepctClass]
        public List<double> MyMethodD(List<double> array)
        {
            return array;
        }
        [MyAsepctClass]
        public List<float> MyMethodF(List<float> array)
        {
            return array;
        }
        [MyAsepctClass]
        public List<decimal> MyMethodDE(List<decimal> array)
        {
            return array;
        }
        [MyAsepctClass]
        public List<long> MyMethodL(List<long> array)
        {
            return array;
        }
        [MyAsepctClass]
        public int[] ArrayInt(int[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public string[] ArrayString(string[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public double[] ArrayDouble(double[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public float[] ArrayFloat(float[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public decimal[] Arraydecimal(decimal[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public long[] ArrayLong(long[] array)
        {
            return array;
        }
        [MyAsepctClass]
        public ArrayList GetArrayList(ArrayList array)
        {
            return array;
        }
    }

    [PSerializable]
    public class PropetryBakıcı : LocationInterceptionAspect
    {
        public override void OnGetValue(LocationInterceptionArgs args)
        {
            base.OnGetValue(args);

            if (args.Value is ICollection)
            {
                siralaPropetry mysirala = new siralaPropetry();

                mysirala.Siralaturegore(args);
            }
            else Console.WriteLine("Collection degil");
        }

    }
    public class Customer
    {
        [PropetryBakıcı]
        private readonly int[] _address;

        public Customer(int[] address)
        {
            _address = address;
            
        }
        [PropetryBakıcı]
        public int[] Name { get; set; }
        public int[] Address { get { return _address; } }
    }
}

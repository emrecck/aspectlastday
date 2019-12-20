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
            //MyObject.MyMethod(array);

            //if null ise deafult asc olsun

            int[] dizim = new int[] { 3, 2, 5, 8 };
            var customer = new Customer(dizim);
            int count = 0;
            foreach (int element in customer.pcollection)
            {
                count++;
                Console.WriteLine($"Element #{count}: {element}");
            }

            Console.ReadLine();
        }
    }

    [Serializable]
    public class MyAsepctClass : OnMethodBoundaryAspect
    {
        private string bayrak;
        public string pbayrak
        {
            get
            {
                return bayrak;
            }
            set
            {
                    bayrak = value;
            }
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            if (args.ReturnValue is ICollection)
            {
                sirala mysirala = new sirala();
                mysirala.Siralaturegore(args,bayrak);
            }
            else Console.WriteLine("Collection degil");
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
    public class MyClass
    {
        [MyAsepctClass(pbayrak ="asc")]
        public ICollection MyMethod(ICollection array)
        {
            return array;
        }
    }
    public class Customer
    {
        private ICollection collection;
        [PropetryBakıcı]
        public ICollection pcollection { get; set; }

        public Customer(ICollection collection)
        {
            this.pcollection = collection;
        }
    }
}

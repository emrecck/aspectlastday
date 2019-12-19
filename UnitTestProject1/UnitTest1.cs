﻿using System;
using System.Collections.Generic;
using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodListInt()
        {
            List<int> deneme = new List<int>() { 15, 9, 8, 54, 45, 2, 67, 15, 68 };
            deneme.Sort();
            List<int> array = new List<int>() { 15, 9, 8, 54, 45, 2, 67, 15, 68 };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodI(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodListString()
        {
            List<string> deneme = new List<string>() { "antep", "adana", "yozgat", "ankara", "istanbul", "malatya", "edirne" };
            deneme.Sort();
            List<string> array = new List<string>() { "antep", "adana", "yozgat", "ankara", "istanbul", "malatya", "edirne" };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodS(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodListDouble()
        {
            List<double> deneme = new List<double>() { 15.2, 1.3, 5.9, 2.5, 8.3 };
            deneme.Sort();
            List<double> array = new List<double>() { 15.2, 1.3, 5.9, 2.5, 8.3 };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodD(array);
            array.Sort();
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodListFloat()
        {
            List<float> deneme = new List<float>() { 3.5f, 2.2f, 1.4f, 8.1f, 5.3f };
            deneme.Sort();
            List<float> array = new List<float>() { 3.5f, 2.2f, 1.4f, 8.1f, 5.3f };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodF(array);
            array.Sort();
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodListDecimal()
        {
            List<decimal> deneme = new List<decimal>() { 35, 25, 15, 10, 2, 5, 4 };
            deneme.Sort();
            List<decimal> array = new List<decimal>() { 35, 25, 15, 10, 2, 5, 4 };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodDE(array);
            array.Sort();
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodListLong()
        {
            List<long> deneme = new List<long>() { 10, 5, 2, 4, 9, 11, 45 };
            deneme.Sort();
            List<long> array = new List<long>() { 10, 5, 2, 4, 9, 11, 45 };
            MyClass MyObject = new MyClass();
            MyObject.MyMethodL(array);
            array.Sort();
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodInt()
        {
            int[] deneme = new int[] { 15, 9, 8, 54, 45, 2, 67, 15, 68 };
            Array.Sort(deneme);
            int[] array = new int[] { 15, 9, 8, 54, 45, 2, 67, 15, 68 };
            MyClass MyObject = new MyClass();
            MyObject.ArrayInt(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodString()
        {
            string[] deneme = new string[] { "antep", "adana", "yozgat", "ankara", "istanbul", "malatya", "edirne" };
            Array.Sort(deneme);
            string[] array = new string[] { "antep", "adana", "yozgat", "ankara", "istanbul", "malatya", "edirne" };
            MyClass MyObject = new MyClass();
            MyObject.ArrayString(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodDouble()
        {
            double[] deneme = new double[] { 15.2, 1.3, 5.9, 2.5, 8.3 };
            Array.Sort(deneme);
            double[] array = new double[] { 15.2, 1.3, 5.9, 2.5, 8.3 };
            MyClass MyObject = new MyClass();
            MyObject.ArrayDouble(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        [TestMethod]
        public void TestMethodFloat()
        {
            float[] deneme = new float[] { 3.5f, 2.2f, 1.4f, 8.1f, 5.3f };
            Array.Sort(deneme);
            float[] array = new float[] { 3.5f, 2.2f, 1.4f, 8.1f, 5.3f };
            MyClass MyObject = new MyClass();
            MyObject.ArrayFloat(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        public void TestMethodDecimal()
        {
            decimal[] deneme = new decimal[] { 35, 25, 15, 10, 2, 5, 4 };
            Array.Sort(deneme);
            decimal[] array = new decimal[] { 35, 25, 15, 10, 2, 5, 4 };
            MyClass MyObject = new MyClass();
            MyObject.Arraydecimal(array);
            CollectionAssert.AreEqual(deneme, array);
        }
        public void TestMethodLong()
        {
            long[] deneme = new long[] { 10, 5, 2, 4, 9, 11, 45 };
            Array.Sort(deneme);
            long[] array = new long[] { 10, 5, 2, 4, 9, 11, 45 };
            MyClass MyObject = new MyClass();
            MyObject.ArrayLong(array);
            CollectionAssert.AreEqual(deneme, array);
        }
    }
}
using System;

namespace Lesson2
{
    class Program
    {
        public class TestCase
        {
            public int[] X { get; set; }
            public int searchValue { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }

        public class TestCaseLinkedList
        {
            public LinkedList LinkedListTest { get; set; }
            public int Value { get; set; }
            public int[] Expected { get; set; }
            public int ExpectedSearch { get; set; }
            public Exception ExpectedException { get; set; }
        }
        static bool MassTect (int[] a, int[] b)
        {
            bool flag = false;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == b[i])
                    {
                        flag = true;
                    }
                    else return false;
                }
                return flag;
            }
            else return false;
        }
        static void TestLinkedListFindNode(TestCaseLinkedList testCaseLinkedList)
        {
            try
            {
                var a = testCaseLinkedList.LinkedListTest.FindNode(testCaseLinkedList.Value);
                if (a.Value == testCaseLinkedList.ExpectedSearch)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCaseLinkedList.ExpectedException != null)
                {

                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestLinkedList(TestCaseLinkedList testCaseLinkedList)
        {
            try
            {
                testCaseLinkedList.LinkedListTest.AddNode(testCaseLinkedList.Value);
                var mass = testCaseLinkedList.LinkedListTest.mass();
                
                    if (MassTect(mass, testCaseLinkedList.Expected) == true)
                    {
                        Console.WriteLine("VALID TEST");
                    }
                    else
                    {
                        Console.WriteLine("INVALID TEST");
                    }
                
            }
            catch (Exception)
            {
                if (testCaseLinkedList.ExpectedException != null)
                {
                   
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestLinkedListAddNodeAfter(TestCaseLinkedList testCaseLinkedList)
        {
            try
            {
                var a = testCaseLinkedList.LinkedListTest.FindNode(testCaseLinkedList.ExpectedSearch);
                testCaseLinkedList.LinkedListTest.AddNodeAfter(a, testCaseLinkedList.Value);
                var mass = testCaseLinkedList.LinkedListTest.mass();
                if (MassTect(mass, testCaseLinkedList.Expected) == true)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCaseLinkedList.ExpectedException != null)
                {

                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestLinkedListAddRemoveNodeInt(TestCaseLinkedList testCaseLinkedList)
        {
            try
            {
                testCaseLinkedList.LinkedListTest.RemoveNode(testCaseLinkedList.Value);
                var mass = testCaseLinkedList.LinkedListTest.mass();
                if (MassTect(mass, testCaseLinkedList.Expected) == true)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCaseLinkedList.ExpectedException != null)
                {

                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }
        static void TestLinkedListAddRemoveNode(TestCaseLinkedList testCaseLinkedList)
        {
            try
            {
                var a = testCaseLinkedList.LinkedListTest.FindNode(testCaseLinkedList.ExpectedSearch);
                testCaseLinkedList.LinkedListTest.RemoveNode(testCaseLinkedList.Value);
                var mass = testCaseLinkedList.LinkedListTest.mass();
                if (MassTect(mass, testCaseLinkedList.Expected) == true)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCaseLinkedList.ExpectedException != null)
                {

                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        static void TestBinarySearch(TestCase testCase)
        {
            try
            {
                var actual = BinarySearch(testCase.X, testCase.searchValue);
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                {
                    //TODO add type exception tests;
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0; //O(1)
            int max = inputArray.Length - 1;//O(1)
            while (min <= max) //O(N)
            {
                int mid = (min + max) / 2; //O(1)
                if (searchValue == inputArray[mid])//O(1)
                {
                    return inputArray[mid];
                }
                else if (searchValue < inputArray[mid])//O(1)
                {
                    max = mid - 1;
                }
                else//O(1)
                {
                    min = mid + 1;
                }
            }
            return -1;//O(1)
            // 2 + N + 5 = N
            //Асимптотическая сложность O(N)
        }

        static void Main(string[] args)
        {


            LinkedList ds = new LinkedList();
            int[] masstest1 = new int[] { 10 };
            TestCaseLinkedList test1 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 10,
                Expected = masstest1,
                ExpectedException = null,
            };
            TestLinkedList(test1);

            int[] masstest2 = new int[] { 10, 55 };
            TestCaseLinkedList test2 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 55,
                Expected = masstest2,
                ExpectedException = null,
            };
            TestLinkedList(test2);

            int[] masstest3 = new int[] { 10, 55, 68 };
            TestCaseLinkedList test3 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 68,
                Expected = masstest3,
                ExpectedException = null,
            };
            TestLinkedList(test3);

            int[] masstest4 = new int[] { 10, 55, 68, 75 };
            TestCaseLinkedList test4 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 75,
                Expected = masstest4,
                ExpectedException = null,
            };
            TestLinkedList(test4);
           
            TestCaseLinkedList test5 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 55,
                ExpectedSearch = 55,
                ExpectedException = null,
            };
            TestLinkedListFindNode(test5);
            int[] masstest6 = new int[] { 10, 55, 11, 68, 75 };
            TestCaseLinkedList test6 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 11,
                Expected = masstest6,
                ExpectedSearch = 55,
                ExpectedException = null,
            };
            TestLinkedListAddNodeAfter(test6);
            int[] masstest7 = new int[] { 55, 11, 68, 75 };
            TestCaseLinkedList test7 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 0,
                Expected = masstest7,
                ExpectedSearch = 55,
                ExpectedException = null,
            };
            TestLinkedListAddRemoveNodeInt(test7);

            int[] masstest8 = new int[] { 55, 11, 75 };
            TestCaseLinkedList test8 = new TestCaseLinkedList()
            {
                LinkedListTest = ds,
                Value = 2,
                Expected = masstest8,
                ExpectedSearch = 55,
                ExpectedException = null,
            };
            TestLinkedListAddRemoveNode(test8);

            int[] intArray = new int[] { 1, 6, 77, 123, 444, 555, 660 };
            var testCase1 = new TestCase()
            {
                X = intArray,
                searchValue = 6,
                Expected = 6,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = intArray,
                searchValue = 6,
                Expected = 2,
                ExpectedException = null
            };
            var testCase3 = new TestCase()
            {
                X = intArray,
                searchValue = 555,
                Expected = 555,
                ExpectedException = null
            };

            TestBinarySearch(testCase1);
            TestBinarySearch(testCase2);
            TestBinarySearch(testCase3);

            int[] intArray1 = new int[] { 1, 6, 77, 123, 444, 555 };
            var testCase4 = new TestCase()
            {
                X = intArray1,
                searchValue = 555,
                Expected = 555,
                ExpectedException = null
            };
            TestBinarySearch(testCase4);
            Console.ReadKey();
        }
    }
}

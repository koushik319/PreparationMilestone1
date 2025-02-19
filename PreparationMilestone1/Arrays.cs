using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PreparationMilestone1
{
    public class Arrays
    {
        #region 1D Array
        public void Onearray()
        {
            Console.WriteLine("Enter the size of Array");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The Values of Array are :");
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        #endregion

        #region Search an element in Array
        public void SearchArray()
        {
            int m,target;
            bool flag = false;
            Console.WriteLine("Enter the size of Array:");
            m = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[m];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the target value");
            target = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == target)
                {
                    flag = true;
                    Console.WriteLine("Element found at index" +" "+i);
                    break;
                }
               
            }
            if (flag == false)
            {
                Console.WriteLine("Element not found...");
            }
            

        }
        #endregion

        #region Count number of even Numbers 

        public void Counteven()
        {
            int n;
            Console.WriteLine("Enter the size of Array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < ar.Length; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for(int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    count = count + 1;
                }
             
            }
            Console.WriteLine("Count of Even Numbers is : "+count);

        }

        #endregion

        #region Minimum element in an Array

        public void MinimumEle()
        {
            int n;
            Console.WriteLine("Enter the size of Array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[n];
            Console.WriteLine("Enter the Array Elements");
            for(int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = arr2[0];
            for(int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < min)
                {
                    min = arr2[i];
                }
            }
            Console.WriteLine("The Minimum Element in the Array is " + min);
        }

        #endregion

        #region Maximum Element in an Array

        public void Maximumelement()
        {
            Console.WriteLine("Enter the size of array");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Maximum Element in an Array is " + max);
            
        }
        #endregion

        #region First and Second Minimum
        public void FirstandSecondMin()
        {
            int  min1, min2;
            Console.WriteLine("Enter the Size of Array :");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array:");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (a[0] < a[1]){
                min1 = a[0];
                min2 = a[1];
            }
            else
            {
                min1 = a[1];
                min2 = a[0];
            }
            for(int i = 2; i < a.Length; i++)
            {
                if (a[i] < min1)
                {
                    min2 = min1;
                    min1 = a[i];
                }
                else if (a[i] < min2)
                {
                    min2 = a[i];
                }
            }
            Console.WriteLine("The Smallest Element in the Array is : " + min1);
            Console.WriteLine("The Second Smallest Element is : " + min2);
        }

        #endregion

        #region Reverse an Array
        public void Reversearray()
        {
           
            Console.WriteLine("Enter the size of Array");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int []a = new int[n];

            Console.WriteLine("Enter the values of Array");

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The Reveresed Array elements are: ");
            for(int i = a.Length-1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }

        }
        #endregion

        #region HashSet -> Unique values
        public void Sorting()
        {

            // With the Help of HashSet we can get Unique Values
            HashSet<int> set = new HashSet<int>();

            set.Add(2);
            set.Add(5);
            set.Add(2);
            set.Add(3);
            set.Add(6);

            foreach(var item in set)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Distinct to get Unique values from Array 
        public void Sorting1()
        {
            int[] a ={ 1, 2, 3,3,5, 4, 6,10, 7, 3, 5, 8, 9, };

            var v = a.Distinct();
            foreach(var item in v)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Second Largest and Smallest Element in Array
        
        public void Slse()
        {
            int n, temp;
            Console.WriteLine("Enter the size of Array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("The Second Largest Element is " + a[n - 2]);
            Console.WriteLine("Smallest Element is " + a[0]);
            
        }

        #endregion

        #region Largest and Second Largest

        public void LarandSecLar()
        {
            Console.WriteLine("Enter the size of Array");
            int n,max1,max2;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (a[0] > a[1])
            {
                max1 = a[0];
                max2 = a[1];
            }
            else
            {
                max1 = a[1];
                max2 = a[0];
            }

            for(int i = 2; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max2 = max1;
                    max1 = a[i];
                }
                else if (a[i] > max2)
                {
                    max2 = a[i];
                }
            }
            Console.WriteLine("Max element is : " + max1);
            Console.WriteLine("Second Largest element is : " + max2);

        }

        #endregion

        #region Largest and Smallest Element

        public void LarandSma()
        {
            Console.WriteLine("Enter the size of Array");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array");
            for(int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = a[0];
            int max = a[0];
            for(int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                else if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Minimum elemnt is " + min);
            Console.WriteLine("Maximum element is " + max);
        }
        #endregion

        #region Delete An element from Array

        public void ArrayDel()
        {
            Console.WriteLine("Enter the size of Array");
            int n,i, st, loc, flag=0;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the values of Array");
            for( i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to delete");
            st = Convert.ToInt32(Console.ReadLine());
            for( i = 0; i < n; i++)
            {
                if (a[i] == st)
                {
                    flag = 1;
                    loc = i;
                    break;
                }
            }
            if (flag == 1)
            {
                loc = i;
                for( i = loc; i < n-1; i++)
                {
                    a[i] = a[i + 1];
                }
                Console.WriteLine("The new Array Elements are :");
                for( i = 0; i < n-1; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
            else
            {
                Console.WriteLine("The Element is not found ");
            }

           
        }
        #endregion


    }
}

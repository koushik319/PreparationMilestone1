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
    }
}

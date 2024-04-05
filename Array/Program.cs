using System;
namespace Array;
class Program
{
    public static void Main(string[] args)
    {
        // //types of array creation
        // int[] array1 = new int[5];
        // // int[] array2 = new int[5]{1,2,3,4,5};
        // // int[]  array3 = new int[]{6,7,8,9,0};

        // //array1 intialization
        // for(int i = 0; i < array1.Length ; i++)
        // {
        //     array1[i] = int.Parse(Console.ReadLine());
        // }
        // for(int i = 0; i < array1.Length ; i++)
        // {
        //     Console.WriteLine(array1[i]);
        // }

        // int i = 0;
        // int[] a = new int[100];
        // int n = int.Parse(Console.ReadLine());
        // for(i=0;i<n;i++)
        // {
        //     a[i] = Convert.ToInt32(Console.ReadLine());
        // }
        // for(i=n-1;i>=0;i--)
        // {
        //     Console.Write("{0}", a[i] + " ");
        // }


        // // Practise Ass - Ques 2: get size and elements and display the sum of elements
        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // int[] array = new int[n];
        // for(int i = 0; i < n ; i++)
        // {
        //     array[i] = int.Parse(Console.ReadLine());
        // }
        // for(int i = 0; i < n ; i++)
        // {
        //     sum += array[i];
        // }
        // Console.WriteLine($"{sum}");


        // //Practice Assignment-Ques 3: Max and Min element in the array
        // int n = int.Parse(Console.ReadLine());
        // int[] arr = new int[n];
        // for(int i=0; i<n; i++)
        // {
        //     arr[i] = int.Parse(Console.ReadLine());
        // }
        // int max = arr[0];
        // int temp = arr[0];
        // int min = 0;
        // for(int i=1; i<n; i++)
        // {
        //     if(arr[i]>temp)
        //     {
        //         max = arr[i];
        //     }
        //     else
        //     {
        //         min = temp;
        //     }
        // }
        // Console.WriteLine("Max: "+ max);
        // for(int i=1; i<n; i++)
        // {
        //     if(arr[i]<temp)
        //     {
        //         min = arr[i];
        //     }
        // }
        // Console.WriteLine("Min: "+ min);


        //Practice Assignment-Ques 4: Odd and even numbers in an array
        int n = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] odd = new int[n];
        int[] even = new int[n];
        int j=0, k=0;
        for(int i=0; i<n; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        for(int i=0; i<n; i++)
        {
            if(array1[i] % 2 ==0)
            {
                even[j] = array1[i];
                j++;
            }
            else
            {
                odd[k] = array1[i];
                k++;
            }
        }

        Console.Write("Odd Numbers : ");
        for(int i=0; i<k ; i++)
        {
            Console.Write(odd[i]+" ");
        }
        Console.WriteLine();
        Console.Write("Even Numbers : ");
        for(int i=0; i<j ; i++)
        {
            Console.Write(even[i]+" ");
        }



       

    }
}
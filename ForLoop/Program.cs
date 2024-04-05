using System;
namespace ForLoop;
class Program  
{
    public static void Main(string[] args)
    {
        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // for(int i = 1; i <= n; i++)
        // {
        //     sum += 2*i;
        // }
        // Console.WriteLine(sum);

        // int n = int.Parse(Console.ReadLine());
        // int sum = 0;
        // for(int i =1; i<=n ; i++)
        // {
        //     Console.WriteLine("{0}", i);
        //     sum += i;
        // }
        // Console.WriteLine(sum);

        // // while - q1
        // int[] arr = new int[10]{10, 20, 30, 40, 50, 60, 70, 80, 90,100};
        // int n = int.Parse(Console.ReadLine());
        // int i = 0;
        // while(n > arr[i])
        // {
        //     Console.WriteLine(arr[i]);
        //     i++;
        // } 

        // //while q2
        // int num = int.Parse(Console.ReadLine());
        // int rev = 0,rem;
        // while(num!=0)
        // {
        //     rem = num % 10;
        //     rev = rev * 10 + rem;
        //     num = num/10;
        // }
        // Console.WriteLine(rev);

        // //while q3
        // int n = int.Parse(Console.ReadLine());
        // int n1 = 0;
        // int n2 = 1;
        // int n3 = 0;
        // Console.WriteLine(n1);
        // Console.WriteLine(n2);
        // while(n3 < n)
        // {
        //     n3 = n1 + n2;
        //     Console.WriteLine(n3);
        //     n1 = n2;
        //     n2 = n3;
        // }


        //6.ForLoop
        int n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++)
        {
            Console.WriteLine(i*i*i);
        }
    }
}
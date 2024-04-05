using System;
using System.Diagnostics;
namespace Basic;
class Program
{
    public static void Main(string[] args)
    {
        // //Conversion of c to f and k
        // double celsius = double.Parse(Console.ReadLine());
        // double fahrenheit = celsius * 9/5 + 32;
        // double kelvin = celsius + 273.15;
        // Console.WriteLine(fahrenheit);
        // Console.WriteLine(kelvin);

        // //sum of digits
        // int num = int.Parse(Console.ReadLine());
        // int r1 = num % 10;
        // int r2 = num / 10;
        // int sum = r1+r2;
        // Console.WriteLine(sum);

        // //Calculate the total price - price + 18% tax
        // int price = int.Parse(Console.ReadLine());
        // int per = price * 18/100;
        // int total = price + per;
        // Console.WriteLine(total);

        // //Calculate the distance
        // double m = double.Parse(Console.ReadLine());
        // double s = double.Parse(Console.ReadLine());
        // double km = m / 1000;
        // double d = km;

        // //ternary operation
        // int num1 = int.Parse(Console.ReadLine());
        // int num2 = int.Parse(Console.ReadLine());
        // bool result = num1 <= num2 ? true : false;
        // Console.WriteLine(result);

        //calculate sum, percent
        int sum = int.Parse(Console.ReadLine());
        sum += sum;
        sum = int.Parse(Console.ReadLine());
        sum += sum;
        sum = int.Parse(Console.ReadLine());
        sum += sum;
        Console.WriteLine("Sum:"+sum);
        double Percentage = (double)sum/300 * 100;
        Console.WriteLine("Percentage:"+Percentage);



    }
}

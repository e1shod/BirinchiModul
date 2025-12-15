using System;

namespace UyIshi1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Add() overloading: 2 float, 3 float, 2 string
            //static float Add(float a, float b) => a + b;
            //static float Add(float a, float b, float c) => a + b + c;
            //static string Add(string s1, string s2) => s1 + s2;

            //Console.WriteLine(Add(2.5f, 3.1f));        
            //Console.WriteLine(Add(1.1f, 2.2f, 3.3f));  
            //Console.WriteLine(Add("Hello", "World"));  

            // 2. repeat() void function
            //static void repeat(int a, int b)
            //{
            //    for (int i = 0; i < b; i++)
            //        Console.WriteLine(a);
            //}
            //static void repeat(int a)
            //{
            //    for (int i = 0; i < a; i++)
            //        Console.WriteLine(a);
            //}
            //repeat(5);      
            //repeat(3, 2);


            // 3. calculate() overloading
            //static int calculate(int a, int b) => a + b;
            //static int calculate(int a, int b, int c) => a * b * c;

            //Console.WriteLine(calculate(3, 4));       
            //Console.WriteLine(calculate(2, 3, 4))

            // 4. getAmountDigit() overloading
            //static int getAmountDigit(int num)
            //{
            //    return num.ToString().Length;
            //}
            //static int getAmountDigit(string s)
            //{
            //    int count = 0;
            //    foreach (char c in s)
            //        if (char.IsDigit(c))
            //            count++;
            //    return count;
            //}

            //Console.WriteLine(getAmountDigit(12345));          
            //Console.WriteLine(getAmountDigit("ab123c45"));

            // 5. findMax() overloading

            //  static int findMax(int a, int b, int c) => Math.Max(a, Math.Max(b, c));
            //static int findMax(int a, int b, int c, int d) => Math.Max(findMax(a, b, c), d);
            //static int findMax(int a, int b, int c, int d, int e) => Math.Max(findMax(a, b, c, d), e);


            // Console.WriteLine(findMax(1, 5, 3));               
            //Console.WriteLine(findMax(2, 6, 4, 8));            
            //Console.WriteLine(findMax(1, 9, 5, 3, 7));
            // 6. multiplication() overloading
            //static int multiplication(int n)
            //{
            //    int result = 1;
            //    for (int i = 1; i <= n; i++)
            //        result *= i;
            //    return result;
            //}

            //static int multiplication(int a, int b)
            //{
            //    int result = 1;
            //    for (int i = a; i <= b; i++)
            //        result *= i;
            //    return result;
            //}

            //static int multiplication(int a, int b, int c)
            //{
            //    return a * b * c;
            //}

            //Console.WriteLine(multiplication(5));
            //Console.WriteLine(multiplication(4, 7));
            //Console.WriteLine(multiplication(2, 8, 5));



            // 7. Necha xonali ekanligini rekursiya orqali aniqlash
            //static int CountDigitsRecursive(int n)
            //{
            //    n = Math.Abs(n); // manfiy sonni ham hisoblash
            //    if (n < 10) return 1;
            //    return 1 + CountDigitsRecursive(n / 10);
            //}

            
            //Console.WriteLine(CountDigitsRecursive(12345));   
            //Console.WriteLine(CountDigitsRecursive(7));       
            //Console.WriteLine(CountDigitsRecursive(-9876));   


            //// 8. a dan b gacha bo'lgan sonlar yig'indisi (rekursiya)
            //static int SumRangeRecursive(int a, int b)
            //{
            //    if (a > b) return 0;
            //    return a + SumRangeRecursive(a + 1, b);
            //}

            //Console.WriteLine(SumRangeRecursive(1, 5));       
            //Console.WriteLine(SumRangeRecursive(3, 7));


            //// 9. 1 dan n gacha sonlarning kub yig'indisi (rekursiya)
            //static int SumCubesRecursive(int n)
            //{
            //    if (n <= 0) return 0;
            //    return n * n * n + SumCubesRecursive(n - 1);

            //    Console.WriteLine(SumCubesRecursive(3));
            //    Console.WriteLine(SumCubesRecursive(7));
            }

        }
    }
}

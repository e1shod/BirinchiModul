namespace IshDars2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //2-misol

            //for (int i = 25; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //3-misol

            //for (int i = 12; i <= 200; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //4-misol

            //for (int i = 15; i >= 2; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //5-misol

            //for (int i = 120; i >= 23; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //6-misol

            //for (int i = 10; i <= 50; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}


            //7-misol

            //for (int i = 120; i <= 250; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}


            //8-misol

            //for (int i = 100; i >= 50; i--)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}

            //9-misol

            //for (int i = 80; i >= 20; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //10-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //11-misol

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 4 == 0 && i % 7 == 0)
            //        Console.WriteLine(i);
            //}


            //12-misol

            //int count = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 8 == 0)
            //        count++;
            //}
            //Console.WriteLine("8 ga karrali sonlar soni: " + count);





            //13-misol

            //for (int i = b; i >= a; i--)
            //{
            //    if (i % 9 == 0 || i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //14-misol

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 1)
            //        sum += i;
            //}
            //Console.WriteLine("Yig‘indi: " + sum);

            //15-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var yuzlar = i / 100;
            //   var onlar = (i / 10) % 10;
            //   var birlar = i % 10;

            //    if ((yuzlar + onlar + birlar) > 20)
            //        Console.WriteLine(i);
            //}


            //16-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var yuzlar = i / 100;
            //   var birlar = i % 10;

            //    if (yuzlar == birlar)
            //        Console.WriteLine(i);
            //}

            //17-misol

            //int count = 0;
            //int sum = 0;
            //for (int i = 10; i <= 99; i++)
            //{
            //   var onlar = i / 10;
            //   var birlar = i % 10;

            //    if (onlar * birlar > 12)
            //    {
            //        count++;
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("Miqdori: " + count);
            //Console.WriteLine("Yig‘indi: " + sum);

            //18-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var onlar = (i / 10) % 10;

            //    if (onlar == 2 || onlar == 5)
            //        Console.WriteLine(i);
            //}

            //19-misol

            //int a =var.Parse(Console.ReadLine());


            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(a);
            //}

            //20-misol
            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());


            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine(a);
            //}

            //21-misol
            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());


            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(b);
            //}

            //22-misol
            //int a =var.Parse(Console.ReadLine());

            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        Console.WriteLine(i);
            //}


            //23-misol

            //int a =var.Parse(Console.ReadLine());

            //int countDiv = 0;
            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        countDiv++;
            //}
            //Console.WriteLine("Bo‘luvchilar soni: " + countDiv);

            //2-4misol

            //int a =var.Parse(Console.ReadLine());

            //int sumDiv = 0;
            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        sumDiv += i;
            //}
            //Console.WriteLine("Bo‘luvchilar yig‘indisi: " + sumDiv);

            //25-misol

            //int a =var.Parse(Console.ReadLine());

            //bool isPrime = true;

            //if (a < 2) isPrime = false;

            //for (int i = 2; i <= Math.Sqrt(a); i++)
            //{
            //    if (a % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isPrime);


            //26-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //bool primeA = true, primeB = true;

            //if (a < 2) primeA = false;
            //if (b < 2) primeB = false;

            //for (int i = 2; i <= Math.Sqrt(a) && primeA; i++)
            //{
            //    if (a % i == 0) primeA = false;
            //}
            //for (int i = 2; i <= Math.Sqrt(b) && primeB; i++)
            //{
            //    if (b % i == 0) primeB = false;
            //}

            //if (primeA && primeB)
            //    Console.WriteLine(a + b);
            //else
            //    Console.WriteLine(a * b);


            //27-misol


            //for (int kg = 3; kg <= 60; kg++)
            //{
            //    Console.WriteLine(kg + " kg shakar: " + (kg * 7000) + " so'm");
            //}

            //28-misol


            //int n =var.Parse(Console.ReadLine());
            //int countNotDiv3 = 0;

            //for (int i = 23; i <= n; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //        countNotDiv3++;
            //    }
            //}
            //Console.WriteLine("Sonlar soni: " + countNotDiv3);



            //29-misol


            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //int countA = 0, countB = 0;

            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0) countA++;
            //}
            //for (int i = 1; i <= b; i++)
            //{
            //    if (b % i == 0) countB++;
            //}

            //if (countA > countB)
            //    Console.WriteLine("Ko‘p bo‘luvchilar: " + a);
            //else if (countB > countA)
            //    Console.WriteLine("Ko‘p bo‘luvchilar: " + b);
            //else
            //    Console.WriteLine("Bo‘luvchilar soni teng");

            //30-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //int sumAB = 0;
            //for (int i = a + 1; i < b; i++)
            //{
            //    sumAB += i;
            //}
            //Console.WriteLine("Yig‘indi: " + sumAB);


            //31-misol

            //for (int i = 14; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 11; i <= 99; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 12; i <= 200; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 25; i >= 10; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 500; i >= 80; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 11; i <= 88; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 12; i <= 25; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 15; i <= 88; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}

            //1-misol

            //for (int i = 99; i >= 10; i--)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //10-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //}

            //11-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 5 == 0 && i % 6 == 0)
            //        Console.WriteLine(i);
            //}

            //12-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //int count = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    if (i % 10 == 0)
            //        count++;
            //}
            //Console.WriteLine("10 ga karrali sonlar soni: " + count);

            //13-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());


            //for (int i = b; i >= a; i--)
            //{
            //    if (i % 7 == 0 || i % 8 == 0)
            //        Console.WriteLine(i);
            //}

            //14-misol

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //        sum += i;
            //}
            //Console.WriteLine("Yig‘indi: " + sum);

            //15-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var yuzlar = i / 100;
            //   var onlar = (i / 10) % 10;
            //   var birlar = i % 10;

            //    if ((yuzlar + onlar + birlar) > 18)
            //        Console.WriteLine(i);
            //}

            //16-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var yuzlar = i / 100;
            //   var birlar = i % 10;

            //    if (yuzlar == birlar)
            //        Console.WriteLine(i);
            //}

            //17-misol

            //int count17 = 0;
            //int sum17 = 0;

            //for (int i = 10; i <= 99; i++)
            //{
            //   var onlar = i / 10;
            //   var birlar = i % 10;

            //    if (onlar * birlar > 15)
            //    {
            //        count17++;
            //        sum17 += i;
            //    }
            //}
            //Console.WriteLine("Miqdori: " + count17);
            //Console.WriteLine("Yig‘indi: " + sum17);

            //18-misol

            //for (int i = 100; i <= 999; i++)
            //{
            //   var onlar = (i / 10) % 10;

            //    if (onlar == 4 || onlar == 7)
            //        Console.WriteLine(i);
            //}

            //19-misol

            //int a =var.Parse(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(a);
            //}

            //20-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //for (int i = 0; i < b; i++)
            //{
            //    Console.WriteLine(a);
            //}

            //21-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //for (int i = 0; i < a; i++)
            //{
            //    Console.WriteLine(b);
            //}

            //22-misol

            //int a =var.Parse(Console.ReadLine());

            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        Console.WriteLine(i);
            //}

            //23-misol
            //int a =var.Parse(Console.ReadLine());

            //int count23 = 0;
            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        count23++;
            //}
            //Console.WriteLine("Bo‘luvchilar soni: " + count23);

            //24-misol

            //int a =var.Parse(Console.ReadLine());

            //int sum24 = 0;
            //for (int i = 1; i <= a; i++)
            //{
            //    if (a % i == 0)
            //        sum24 += i;
            //}
            //Console.WriteLine("Bo‘luvchilar yig‘indisi: " + sum24);

            //25-misol

            //int a =var.Parse(Console.ReadLine());

            //bool isPrime = true;

            //if (a < 2) isPrime = false;

            //for (int i = 2; i <= Math.Sqrt(a); i++)
            //{
            //    if (a % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(isPrime);

            //26-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());


            //bool primeA = true, primeB = true;

            //if (a < 2) primeA = false;
            //if (b < 2) primeB = false;

            //for (int i = 2; i <= Math.Sqrt(a) && primeA; i++)
            //{
            //    if (a % i == 0) primeA = false;
            //}
            //for (int i = 2; i <= Math.Sqrt(b) && primeB; i++)
            //{
            //    if (b % i == 0) primeB = false;
            //}

            //if (primeA && primeB)
            //    Console.WriteLine(a + b);
            //else
            //    Console.WriteLine(a * b);

            //27-misol
            //int a =var.Parse(Console.ReadLine());

            //int count28 = 0;
            //for (int i = 35; i <= n; i++)
            //{
            //    if (i % 3 != 0)
            //    {
            //        Console.WriteLine(i);
            //        count28++;
            //    }
            //}
            //Console.WriteLine("Sonlar soni: " + count28);



            //28-misol

            //for (int kg = 13; kg <= 60; kg++)
            //{
            //    Console.WriteLine(kg + " kg shakar: " + (kg * 4000) + " so'm");
            //}

            //29-misol


            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //int countA29 = 0, countB29 = 0;

            //for (int i = 1; i <= a; i++)
            //    if (a % i == 0) countA29++;
            //for (int i = 1; i <= b; i++)
            //    if (b % i == 0) countB29++;

            //if (countA29 > countB29)
            //    Console.WriteLine("Ko‘p bo‘luvchilar: " + a);
            //else if (countB29 > countA29)
            //    Console.WriteLine("Ko‘p bo‘luvchilar: " + b);
            //else
            //    Console.WriteLine("Bo‘luvchilar soni teng");

            //30-misol

            //int a =var.Parse(Console.ReadLine());
            //int b =var.Parse(Console.ReadLine());

            //int sum30 = 0;
            //for (int i = a + 1; i < b; i++)
            //{
            //    sum30 += i;
            //}
            //Console.WriteLine("Yig‘indi: " + sum30);


            //31-misol


            //double price = double.Parse(Console.ReadLine());

            //for (double kg = 1.1; kg <= 2.0; kg += 0.1)
            //{
            //    Console.WriteLine(kg.ToString("F1") + " kg: " + (price * kg));
            //}

            //32-misol

            //int N =var.Parse(Console.ReadLine());

            //for (int i = 0; i <= N; i++)
            //{
            //    Console.WriteLine(Math.Sqrt(i));
            //}

            //33-misol

            //int n =var.Parse(Console.ReadLine());
            //int k =var.Parse(Console.ReadLine());
            //int result = 1;

            //for (int i = 0; i < k; i++)
            //{
            //    result *= n;
            //}
            //Console.WriteLine("Natija: " + result);









            ////---------------WHILEDA ISHLASH
            //1-misol

            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int temp = n;

            //while (temp != 0)
            //{
            //    temp /= 10;
            //    count++;
            //}

            //Console.WriteLine("Son xonalar soni: " + count);

            //2-misol

            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;
            //int temp = n;

            //while (temp != 0)
            //{
            //    sum += temp % 10;
            //    temp /= 10;
            //}

            //Console.WriteLine("Raqamlar yig‘indisi: " + sum);

            //3-misol

            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int temp = n;

            //while (temp != 0)
            //{
            //    if ((temp % 10) % 2 == 0)
            //        count++;
            //    temp /= 10;
            //}

            //Console.WriteLine("Juft raqamlar soni: " + count);

            //4-misol

            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int temp = n;

            //while (temp != 0)
            //{
            //    if ((temp % 10) % 2 == 1)
            //        count++;
            //    temp /= 10;
            //}

            //Console.WriteLine("Toq raqamlar soni: " + count);


            //5-misol

            //int count = 0;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0) break;
            //    count++;
            //}

            //Console.WriteLine("Sonlar miqdori: " + count);

            //6-misol

            //int count = 0;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0) break;
            //    if (n > 10) count++;
            //}

            //Console.WriteLine("10 dan kattalar miqdori: " + count);

            //7-misol

            //int sum = 0;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0) break;
            //    sum += n;
            //}

            //Console.WriteLine("Yig‘indi: " + sum);

            //8-misol
            //int product = 1;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0) break;
            //    product *= n;
            //}

            //Console.WriteLine("Ko‘paytma: " + product);

            //9-misol

            //int sum = 0;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n == 0) break;
            //    if (n > 50) sum += n;
            //}

            //Console.WriteLine("50 dan kattalar yig‘indisi: " + sum);

            //10-misol

            //int count = 0;
            //int n;

            //while (true)
            //{
            //    n = int.Parse(Console.ReadLine());
            //    if (n % 2 == 0) break;
            //    count++;
            //}

            //Console.WriteLine("Kiritilgan sonlar miqdori: " + count);

            //11-misol

            //int n = int.Parse(Console.ReadLine());
            //bool found = false;
            //int temp = n;

            //while (temp != 0)
            //{
            //    if (temp % 10 == 5)
            //    {
            //        found = true;
            //        break;
            //    }
            //    temp /= 10;
            //}

            //Console.WriteLine(found ? "Bor" : "Yo‘q");

            //12-misol

            //int n = int.Parse(Console.ReadLine());
            //bool found = false;
            //int temp = n;

            //while (temp != 0)
            //{
            //    if ((temp % 10) % 2 == 0)
            //    {
            //        found = true;
            //        break;
            //    }
            //    temp /= 10;
            //}

            //Console.WriteLine(found ? "Bor" : "Yo‘q");

            //13-misol

            //int n = int.Parse(Console.ReadLine());
            //int temp = 1;

            //while (temp < n)
            //{
            //    temp *= 3;
            //}

            //if (temp == n)
            //    Console.WriteLine("3 ning darajasi");
            //else
            //    Console.WriteLine("3 ning darajasi emas");

            //1-misol

            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i * j + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //2-misol

            //int a = 2;
            //int b = 6;

            //for (int i = a + 1; i < b; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //Console.WriteLine();

            //3-misol

            //for (int i = 2; i <= 100; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime) Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //4-misol

            //int a = 10, b = 30;

            //for (int i = a + 1; i < b; i++)
            //{
            //    bool isPrime = true;
            //    for (int j = 2; j * j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime) Console.Write(i + " ");
            //}
            //Console.WriteLine();

            //5-misol


            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //6-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0 || j == n - 1)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //7-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0 || j == n - 1)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //8-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine(); // bo‘sh qator
            //}

            //9-misol

            //int n = 5;
            //int mid = n / 2;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0 || j == n - 1 || i == mid)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //10-misol

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i % 2 == 0) Console.Write("* ");
            //        else if (j == 0) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //11-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0) Console.Write("* ");
            //        else if (j == n / 2) Console.Write("*");
            //        else Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //12-misol

            //int n = 5;
            //int mid = n / 2;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == mid || j == mid)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}


            //13-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0 || i == n - 1 || j == 0 || j == n - 1 || i == j || i + j == n - 1)
            //            Console.Write("* ");
            //        else
            //            Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}

            //14-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //        Console.Write("  ");
            //    Console.WriteLine("*");
            //}

            //15-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - i - 1; j++)
            //        Console.Write("  ");
            //    Console.WriteLine("*");
            //}

            //16-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0 || j == n - 1 || i == j || i + j == n - 1)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

            //17-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0 || i == n - 1 || j == i)
            //            Console.Write("* ");
            //        else
            //            Console.Write("  ");
            //    }
            //    Console.WriteLine();
            //}

            //18-misol

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write("* ");
            //    Console.WriteLine();
            //}

            //19-misol

            //int n = 5;

            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write("* ");
            //    Console.WriteLine();
            //}

            //20-misol

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j > i; j--)
            //        Console.Write("  ");
            //    for (int k = 1; k <= i; k++)
            //        Console.Write("* ");
            //    Console.WriteLine();
            //}

            //21-misol

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //        Console.Write(i + " ");
            //    Console.WriteLine();
            //}

            //22-misol

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //        Console.Write("  ");
            //    Console.WriteLine(i);
            //}

            //23-misol

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(i + " ");
            //    Console.WriteLine();
            //}

            //24-misol

            //int n = 5;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0 || i == n - 1 || j == i || j == n - 1 - i)
            //            Console.Write("$");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}

        }


    }
}

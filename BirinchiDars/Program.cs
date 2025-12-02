using System.Data;
using System.Threading.Channels;

namespace BirinchiDars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol
            //int soat = 2;
            //int daqiqa = soat * 60;
            //Console.WriteLine(soat+"soat"+           daqiqa+"daqiqaga teng");

            //2-misol
            //int hafta = 5;
            //int kun = hafta * 7;
            //int soat = kun * 24;
            //Console.WriteLine(hafta +"hafta"+soat + "soatga teng");


            //3-misol
            //int minut = 4;
            //int sekund = minut * 60;
            //Console.WriteLine(minut +"Minut"+sekund+"sekundga teng");

            //4-misol
            //int soat = 25;
            //int minut = soat * 60;
            //int sekund = minut * 60;
            //Console.WriteLine(soat+"soat"+sekund+"sekundga teng");

            //5- misol
            //int hafta = 150;
            //int kun = hafta * 7;
            //int soat = kun * 24;
            //Console.WriteLine(hafta +"hafta"+soat + "soatga teng");


            //6-misol
            //int kun = 4;
            //int soat = kun * 24;
            //int minut = soat * 60;
            //Console.WriteLine(kun +"kun"+minut+"minutga teng");


            //7-misol
            // int soat = 8;
            //int minut = soat * 60;
            //int sekund = minut * 60;
            //Console.WriteLine(soat+"soat"+sekund+"sekundga teng");

            //8- misol
            //int soat = 48;
            //int kun = soat / 24;
            //Console.WriteLine(soat+ "saot"+kun+"kun bolad");


            //9- misol
            //int sekund = 3600;
            //int minut = sekund / 60;
            //int soat = minut / 60;
            //Console.WriteLine(sekund+"sekund"+soat+"soat bo'ladi");


            //10- misol
            //int kun = 24;
            //int hafta = kun / 7;
            //Console.WriteLine(kun + "kun" + hafta + "hafta boladi");

            //11-misol
            //int sekunt = 2400;
            //int minut= sekunt/60;
            //Console.WriteLine(sekunt+"sekunt"+minut+"minutga teg");

            //12-misol
            //int sekun = 2419200;
            //int minut = sekun / 60;
            //int soat = minut / 60;
            //int kun = soat / 24;
            //int hafta = kun / 7;
            //Console.WriteLine(sekun+"sekunt"+hafta +"haftaga teng");

            //13-misol
            //int GB = 5;
            //int mb = GB * 1024;
            //Console.WriteLine(GB+"gegabayt"+mb+"Megabaytga teng");


            //14-misol
            //int MB = 3;
            //int kb = MB * 1024;
            //Console.WriteLine(MB + "MB" + kb + "kb teng");#


            //15-misol
            //int TB= 8;
            //int GB = TB * 1024;
            //int mb = GB * 1024;
            //Console.WriteLine(TB + "Terabayt" + mb + "Megabaytga teng");

            //16-misol
            //int kb = 8;
            //int b = kb * 1024;
            //Console.WriteLine(b);

            //17-misol
            //int mb = 4;
            //int kb = mb * 1024;
            //int b = kb * 1024;
            //int bit = b * 8;
            //Console.WriteLine(bit);


            //18-misol
            //int b = 3;
            //int bit = b * 8;
            //Console.WriteLine(bit);

            //19-misol
            //int mb = 1;
            //int kb = mb * 1024;
            //Console.WriteLine(kb);


            //20-misol
            // int tb = 8;
            //long kb = tb * 1024L* 1024L* 1024L*1024L;
            // Console.WriteLine(kb);



            //21-misol
            //int mb = 12;
            //int kb = mb * 1024;
            //int b = kb * 1024;
            //Console.WriteLine(b);

            //22-misol
            //int gb = 5000;
            //int tb = gb / 1024;
            //Console.WriteLine(tb);

            //23-misol
            //int mb = 3000;
            //int gb = mb / 1024;
            //Console.WriteLine(gb);

            //24-misol
            //float b1 = 12000;
            //float b = b1 / 8;
            //float kb = b / 1024;
            //Console.WriteLine(kb);

            //25 -misol
            //int kb = 2048;
            //int mb= kb / 1024;
            //Console.WriteLine(mb);

            //26-misol
            //int b1 = 16000;
            //float b = b1 / 8;
            //float kb = b / 1024;
            //Console.WriteLine(kb);


            //27-misol
            //int b = 4096;
            //int kb = b / 1024;
            //Console.WriteLine(kb);


            //28-misol
            //int b1 = 3200;
            //int b = b1 / 8;
            //Console.WriteLine(b);

            //29-misol
            //float kb = 1200;
            //float mb = kb / 1024;
            //Console.WriteLine(mb);

            //30-misol
            //float b = 4800;
            //float kb =b/ 1024;
            //float mb = kb / 1024;
            //Console.WriteLine(mb);

            //31-misol
            // int mb = 120000;
            // float gb = mb / 1024;
            //float tb = gb / 1024;
            // Console.WriteLine(tb);

            //32-misol
            //int mb = 3;
            //int kb = 8;
            //int sum = mb * 1024 + kb;
            //Console.WriteLine(sum);

            //33-misol
            //int gb = 7;
            //int mb = gb *1024 +11;
            //int kb = mb * 1024;
            //Console.WriteLine(kb);

            //34-misol;
            //int mb = 3;
            //int kb = mb * 1024 + 82;
            //int b = kb * 1024;
            //Console.WriteLine(b);

            //35-misol
            //int kb = 8;
            //int b = kb * 1024 + 12;
            //int b1 = b * 8;
            //Console.WriteLine(b1);

            //36-misol
            //int mb = 4;
            //int kb =mb*1024 + 10;
            //int b = kb * 1024;
            //int b1 = b * 8;
            //Console.WriteLine(b1);


            //37-misol
            //Console.WriteLine(12345);
            //Console.WriteLine(1234);
            //Console.WriteLine(123);
            //Console.WriteLine(12);
            //Console.WriteLine(1);

            //38-misol
            //Console.WriteLine(1);
            //Console.WriteLine(12);
            //Console.WriteLine(123);
            //Console.WriteLine(1234);
            //Console.WriteLine(12345);

            //39-misol
            //Console.WriteLine(12345);
            //Console.WriteLine(234);
            //Console.WriteLine(3);

            //40-misol
            //Console.WriteLine(1);
            //Console.WriteLine(212);
            //Console.WriteLine(32123);
            //Console.WriteLine(4321234);
            //Console.WriteLine(543212345);

            //41-misol
            //Console.WriteLine(3);
            //Console.WriteLine(232);
            //Console.WriteLine(12321);
            //Console.WriteLine(232);
            //Console.WriteLine(1);

            //42-misol
            //Console.WriteLine(1234321);
            //Console.WriteLine(23432);
            //Console.WriteLine(343);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(656);
            //Console.WriteLine(76567);
            //Console.WriteLine(8765678);

            //43-misol
            //Console.WriteLine("1111111");
            //Console.WriteLine("1  1");
            //Console.WriteLine("1  1");
            //Console.WriteLine("1  1");
            //Console.WriteLine("1111111");


            //44-misol
            //Console.WriteLine("0000000000");
            //Console.WriteLine("00     0");
            //Console.WriteLine("0 0    0");
            //Console.WriteLine("0  0   0");
            //Console.WriteLine("0   0  0");
            //Console.WriteLine("0    0 0");
            //Console.WriteLine("0     00");
            //Console.WriteLine("0000000000");

            //45 -misol
            //int son = 5;
            //int natija = son + 10;
            //Console.WriteLine(natija);


            //46-misol
            //int son = 15;
            //int natija = son - 10;
            //Console.WriteLine(natija);

            //47-misol
            //int son = 5;
            //int natija = son * 10;
            //Console.WriteLine(natija);

            //48-misol
            //int son = 2;
            //int natija = son * son;
            //Console.WriteLine(natija);

            //49-misol
            //int son = 2;
            //int natija = son * son*son;
            //Console.WriteLine(natija);

            //50-misol
            //int son = 2;
            //int natija = son * son*son*son*son;
            //Console.WriteLine(natija);

            //51-misol
            //int a = 3;
            //int b = 2;
            //int sum = a + b;
            //Console.WriteLine(sum);

            //52-misol
            //int a = 3;
            //int b = 2;
            //int sum = a * b;
            //Console.WriteLine(sum);


            //53-misol
            //int a = 3;
            //int b = 2;
            //int c = 1;
            //int d = 2;
            //int sum = a + b +c+d;
            //Console.WriteLine(sum);

            //54-misol
            //float a = 4;
            //float b = 2;
            //float c = 5;
            //float sum = a + b + c / 3;
            //Console.WriteLine(sum);

            //55-misol
            //float a = 4;
            //float b = 2;
            //float c = 5;
            //float d = 3;
            //float e = 2;
            //float sum = a + b + c +d+e / 5;
            //Console.WriteLine(sum);

            //56-misol
            //float a = 4;
            //float b = 2;
            //float c = 5;
            //float d = 3;
            //float e = 2;
            //float f = 2;
            //float v = 6;
            //float i =1
            //float sum = a + b + c + d + e + f +v +i  / 8;
            //Console.WriteLine(sum);

            //57-misol
            //int a = 5;
            //int b = 6;
            //int temp = a;
            // a = b;
            //b=temp;


            //Console.WriteLine("a="+a);
            //Console.WriteLine("b= "+b);

            //58-misol
            //int m = 3;
            //int s = m * 60;
            //Console.WriteLine(s);

            //59-misol
            //int s = 2;
            //int m = s * 60;
            //int se = m * 60;
            //Console.WriteLine(se);


            //60-misol
            //int k = 1;
            //int s = k * 24;
            //int m = s * 60;
            //int se = m * 60;
            //Console.WriteLine(se);

            //61-misol
            //int m = 120;
            //int s = m / 60;
            //Console.WriteLine(s);

            //62-misol
            //int m = 13213;
            //int s = m / 60;
            //int k = s / 24;
            //Console.WriteLine(k);

            //63-misol
            //Console.Write("Yoshingizni kiriting ");
            //int yosh =
            // int.Parse(Console.ReadLine());
            //Console.WriteLine("siz"+yosh+"yil yashagansiz");

            //64-misol
            //int s = 10;
            //Console.WriteLine("bitta katta"+   (s+1));
            //Console.WriteLine("bitta kam"+   (s-1));

            //65-misol
            //Console.WriteLine("son kiriting");
            //int s =
            //    int.Parse(Console.ReadLine());
            //if(s >10 && s < 15)
            //{
            //    Console.WriteLine("Oraliqda"+s);
            //}
            //else { Console.WriteLine("bu son 10 dan katta va 15dan kichik emas"); }


            //66-misol
            //int a = 10;
            //int b = 5;
            //Console.WriteLine("ayirmasi"+(a-b));
            //Console.WriteLine("yigindi"+(a+b));


            //67-misol
            //int a = 3;
            //Console.WriteLine("3 barobar"+(a*3));
            //Console.WriteLine("4 barobar" + (a * 4));
            //Console.WriteLine("5 barobar" + (a * 5));


            //68-misol
            //int s = 13;
            //int n = s % 10;
            //Console.WriteLine(n);


            //69-misol
            //int s = 120;
            //int n = (s / 10)%10;
            //Console.WriteLine(n);


            //70-misol
            //int s = 120;
            //int n = (s / 100);
            //Console.WriteLine(n);

            //71-misol
            //int s = 12000;
            //int n = (s / 1000) % 10;
            //Console.WriteLine(n);

            //72-misol
            //int s = 1420;
            //int n = (s / 100) % 10;
            //Console.WriteLine(n);


            //73-misol
            //int s = 123;
            //int n1 = s / 100;
            //int n2 = (s / 10) % 10;
            //int n3 = s % 10;
            //Console.WriteLine(n1+n2+n3);





            //74-misol
            //int s = 123;
            //int n1 = s / 100;
            //int n2 = (s / 10) % 10;
            //int n3 = s % 10;
            //Console.WriteLine(n1 * n2 * n3);




            //75-misol
            //int s = 123;
            //int n1 = s / 100;
            //int n2 = (s / 10) % 10;
            //int n3 = s % 10;
            //Console.WriteLine( n3 *100+n2*10+n1*1 );






            //76-misol
            //int s = 1234;
            //int n1 = s / 1000;
            //int n2 = (s / 100) % 10;
            //int n3 = (s / 10) % 10;
            //int n4 = s % 10;
            //Console.WriteLine(n1*1000+n2*100+n4*10+n3);


            //77-misol
            //int s = 1234;
            //int n1 = s / 1000;
            //int n2 = (s / 100) % 10;
            //int n3 = (s / 10) % 10;
            //int n4 = s % 10;
            //Console.WriteLine(n1 * 1000 + n3 * 100 + n2 * 10 + n4);

            //78-misol
            //int s = 1234;
            //int n1 = s / 1000;
            //int n2 = (s / 100) % 10;
            //int n3 = (s / 10) % 10;
            //int n4 = s % 10;
            //Console.WriteLine(n3 * 1000 + n2 * 100 + n1 * 10 + n4);



            //79-misol
            //int gb = 2;
            //int mb = gb * 1024;
            //Console.WriteLine(mb);



            //80-misol
            //int gb = 2;
            //int mb = gb * 1024;
            //int kb = mb * 1024;
            //int b = kb * 1024;
            //int b1 = b * 8;
            //Console.WriteLine(b1);

            //81-misol
            //int fleshka = 4;
            //int kino = 2;
            //int n = fleshka / kino;
            //Console.WriteLine(n);

            //82-misol
            //int fleshka = 15;
            //int kino = 5;
            //int n = fleshka / kino;
            //Console.WriteLine(n);



            //83-misol
            //int s = 478;
            //int n1 = (s / 100);
            //int n2 = (s / 10) % 10;
            //int n3 = s % 10;
            //Console.WriteLine(n2*100 +n3*10+n1);

            //84-misol




            //int s = 473;
            //int n1 = (s / 100);
            //int n2 = (s / 10) % 10;
            //int n3 = s % 10;
            //Console.WriteLine(n3*100 +n1*10+n2);

            //85-misol
            //int son = 40;
            //int n = son >> 2;
            //Console.WriteLine(n);



            //86-misol
            //int son = 40;
            //int n = son >> 4;
            //Console.WriteLine(n);


            //87-misol
            //Console.Write("SOn kirirting");
            //int a = int.Parse(Console.ReadLine());
            //int kv = a * a;
            //int d = kv * kv;
            //Console.WriteLine(d);


            //88-misol
           
            //int a = int.Parse(Console.ReadLine());
            //int a2 = a * a;
            //int a3 = a2 * a;
            //int a6 = a3 * a3;
            //Console.WriteLine(a6);



        } 
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* TASK 1
Console.WriteLine("EDED DAXIL EDIN:");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
Console.WriteLine("EDED CUTDUR:");
}
else
{
Console.WriteLine("EDED TEKDIR:");
}
*/

/*  TASK 2
Console.Write("1 CI EDEDI DAXIL EDIN:");
int a = int.Parse(Console.ReadLine());
Console.Write("2 CI EDEDI DAXIL EDIN:");
int b = int.Parse(Console.ReadLine());
if(a%b==0)
{
Console.WriteLine("BOLUNUR");
}
else
{
Console.WriteLine("BOLUNMUR");
}
*/
/*L1:
Console.Write("EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if(!int.TryParse(eded, out n))
{
Console.WriteLine("EDED DAXIL ETMELISIZ:");
goto L1;
}
if(n%10==7)
{
Console.WriteLine("BELI");
}
else
{
Console.WriteLine("XEYR");
}
*/
/* TASK 4
L1:
Console.Write("2 REQEMLI EDED DAXIL EDIN:");
int n;
string eded = Console.ReadLine();
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED DAXIL ETMELISIZ");
goto L1;
}
int digit = (int)Math.Log10(n) + 1;
int a = n % 10;
int b = n / 10;
if (digit == 2 && a == b)
{
Console.WriteLine("BELI:");
}
else
{
Console.WriteLine("XEYR:");
}
*/
/*TASK 5
L1:
Console.Write("2 REQEMLI EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int a = n % 10;
int b = n / 10;
int digit = (int)Math.Log10(n) + 1;
int c = a + b;
if (digit == 2 && c % 2 == 0)
{
Console.WriteLine(a * b);
}
else
{
Console.WriteLine("SERTE UYGUN DEYIL");
}
*/
/* TASK 6
L1:
Console.Write("3 REQEMLI EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int digit=(int)Math.Log10(n) + 1;
int a = n % 10;
int b = (n/10)%10;
int c = n / 100;
int sum = a + c;
if (digit == 3&&sum==b)
{
Console.WriteLine("BELI:");
}
else
{
Console.WriteLine("XEYR");
}

/* TASK7
L1:
Console.Write("3 REQEMLI EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int digit = (int)Math.Log10(n) + 1;

int a = n % 10;
int b = (n / 10) % 10;
int c = n / 100;
int sum = a + b + c;
int pow2 =(int)Math.Pow(c, 2);
if (digit == 3 && sum == pow2)
{
Console.WriteLine("BELI:");
}
else
{
Console.WriteLine("XEYR");
}
*/
/* TASK 8
Console.WriteLine("REQEM DAXIL EDIN:");
int n = int.Parse(Console.ReadLine());
switch (n)
{
case 1:
Console.WriteLine("1 CI GUN");
break;
case 2:
Console.WriteLine("2 CI GUN");
break;
case 3:
Console.WriteLine("3 CU GUN");
break;
case 4:
Console.WriteLine("4 CU GUN");
break;
case 5:
Console.WriteLine("5 CI GUN");
break;
case 6:
Console.WriteLine("6 CI GUN");
break;
case 7:
Console.WriteLine("7 CI GUN");
break;
}
*/



/* TASK 9
Console.WriteLine("REQEM DAXIL EDIN:");
int n = int.Parse(Console.ReadLine());
switch (n)
{
case 1:
Console.WriteLine("YANVAR");
break;
case 2:
Console.WriteLine("FEVRAL");
break;
case 3:
Console.WriteLine("MART");
break;
case 4:
Console.WriteLine("APREL");
break;
case 5:
Console.WriteLine("MAY");
break;
case 6:
Console.WriteLine("IYUN");
break;
case 7:
Console.WriteLine("IYUL");
break;
case 8:
Console.WriteLine("AVQUST");
break;
case 9:
Console.WriteLine("SENTYABR");
break;
case 10:
Console.WriteLine("OKTYABR");
break;
case 11:
Console.WriteLine("NOYABR");
break;
case 12:
Console.WriteLine("DEKABR");
break;
}
*/
/* TASK 10
Console.Write("1 CI EDEDI DAXIL EDIN:");
int a = int.Parse(Console.ReadLine());
Console.Write("2 CI EDEDI DAXIL EDIN:");
int b = int.Parse(Console.ReadLine());
Console.Write("3 CI EDEDI DAXIL EDIN:");
int c = int.Parse(Console.ReadLine());
Console.Write("4 CI EDEDI DAXIL EDIN:");
int d = int.Parse(Console.ReadLine());
Console.Write("5 CI EDEDI DAXIL EDIN:");
int e = int.Parse(Console.ReadLine());
Console.Write("6 CI EDEDI DAXIL EDIN:");
int f = int.Parse(Console.ReadLine());
if (a > b && a > c && a > d && a > e && a > f)
{
Console.WriteLine(a);
}
else if(b >a && b > c && b > d && b > e && b > f)
{
Console.WriteLine(b);
}
else if (c > a && c > b && c > d && c > e && c > f)
{
Console.WriteLine(c);
}
else if (d > a && d > b && d > c && d > e && b > f)
{
Console.WriteLine(d);
}
else if (e > a && e > b && e > c && e > d && e > f)
{
Console.WriteLine(e);
}
else if (f > a && f > b && f > c && f > d && f > e)
{
Console.WriteLine(f);
}
*/
/*TASK 11
L1:
Console.WriteLine("6 REQEMLI EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int digit = (int)Math.Log10(n) + 1;
int x = n % 10;
int y = (n/10)%10;
int z = (n / 100) % 10;
int a = (n / 1000) % 10;
int b = (n / 10000) % 10;
int c = n / 100000;
int sum1 = x + y + z;
int sum2 = a + b + c;
if (digit == 6 && sum1 == sum2)
{
int newnumber = ((n % 100) * 100) + (n / 10000);
int result = (n / 100) % 100+newnumber;
Console.WriteLine(result);
}
*/
/*TASK 12
long x;
long qaliq;
int a = 0;
long newNum = 0;
l1:
Console.Write("6 reqemli ededi qeyd edin: ");
if (!long.TryParse(Console.ReadLine(), out x) || !(99999 < x && x < 1000000))
{
goto l1;
}
x = 80000000 + x * 10 + 8;

long y = (x % 10000) * 10000 + x / 10000;
while (y > 0)
{
qaliq = y % 10;
y /= 10;

newNum = newNum * 10 + qaliq;
}
y = newNum;
newNum = 0;
long qaliq1;
while (y > 0)
{
qaliq1 = y % 10;
y /= 10;
a++;
if (a == 1 || a == 3 || a == 5 || a == 7)
{
qaliq1 = 0;

}

newNum = newNum * 10 + qaliq1;
}

Console.WriteLine(newNum);
*/



/* TASK 13
L1:
Console.WriteLine("6 REQEMLI EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
int digit = (int)Math.Log10(n) + 1;
int a = 8 * (int)Math.Pow(10, 6) + n;
int number = (a * 10) + 8;
int x = (number / 10000);
int z = (number % 10000);
int newnumber = (z * 10000) + x;
if()
*/
/*TASK 13;
long x;
long qaliq, qaliq1;
int a = 0;
long newNum = 0, secNum = 0;
l1:
Console.Write("7 reqemli ededi qeyd edin: ");
if (!long.TryParse(Console.ReadLine(), out x) || !(999999 < x && x < 10000000))
{
goto l1;
}
long endx = x % 1000;
while (endx > 0)
{
qaliq1 = endx % 10;
endx /= 10;
secNum = secNum * 10 + qaliq1;
}
if (x / 10000 == secNum)
{
while (x > 0)
{
    qaliq = x % 10;
    x /= 10;
    if (qaliq == 0)
    {
        a++;
    }
}

Console.WriteLine($"Ededin terkibindeki 0-larin sayi: {a}");
}
else
{
Console.WriteLine("Eded polindrom deyil");
}
*/



/* TASK 14
Console.WriteLine("EDED DAXIL EDIN:");
int n = int.Parse(Console.ReadLine());
int digit = (int)Math.Log10(n) + 1;
switch (digit)
{
case 1:
Console.WriteLine(10 + n);
break;
case 2:
Console.WriteLine(100 + n);
break;
case 3:
Console.WriteLine(1000 + n);
break;
case 4:
Console.WriteLine(10000 + n);
break;
case 5:
Console.WriteLine(100000 + n);
break;
case 6:
Console.WriteLine(1000000 + n);
break;
case 7:
Console.WriteLine(10000000 + n);
break;
case 8:
Console.WriteLine(100000000 + n);
break;
}
*/




/* TASK 15
L1:
Console.WriteLine("EDED DAXIL EDIN:");
string eded = Console.ReadLine();
int n;
if (!int.TryParse(eded, out n))
{
Console.WriteLine("EDED OLMALIDIR:");
goto L1;
}
if (n >= 1 && n <= 365)
{
int ay = n / 30;
int gun = n % 30;

if (gun >= 22 || gun <= 19 && ay == 12 || ay == 1)
{
Console.WriteLine("OGLAQ BURCU:");
}
else if (gun >= 20 || gun <= 18 && ay == 1 || ay == 2)
{
Console.WriteLine("DOLCA BURCU:");
}
else if (gun >= 19 || gun <= 20 && ay == 2 || ay == 3)
{
Console.WriteLine("BALIQLAR BURCU:");
}
else if (gun >= 21 || gun <= 19 && ay == 3 || ay == 4)
{
Console.WriteLine("QOC BURCU:");
}
else if (gun >= 20 || gun < 21 && ay == 4 || ay == 5)
{
Console.WriteLine("BUGA BURCU:");
}
else if (gun >= 21 || gun <= 20 && ay == 5 || ay == 6)
{
Console.WriteLine("EKIZLER BURCU:");
}
else if (gun >= 21 || gun <= 22 && ay == 6 || ay == 7)
{
Console.WriteLine("XERCENG BURCU:");
}
else if (gun >= 23 || gun <= 22 && ay == 7 || ay == 8)
{
Console.WriteLine("SIR BURCU:");
}
else if (gun >= 23 || gun <= 22 && ay == 8 || ay == 9)
{
Console.WriteLine("QIZ BURCU :");
}
else if (gun >= 23 || gun <= 22 && ay == 9 || ay == 10)
{
Console.WriteLine("TEREZI BURCU:");
}
else if (gun >= 23 || gun <= 21 && ay == 10 || ay == 11)
{
Console.WriteLine("EQREB BURCU:");
}
else if (gun >= 22 || gun <= 21 && ay == 11 || ay == 12)
{
Console.WriteLine("OXATAN BURCU:");
}
}
*/


//TASK 16
L1:
Console.WriteLine("6 REQEMLI EDED DAXIL EDIN:");
int n;
int qaliq, size;
int[] reqemler = new int[0];
string eded = Console.ReadLine();
if (!int.TryParse(eded, out n))
{
    Console.WriteLine("EDED DAXIL EDILMELIDIR:");
    goto L1;
}
while (n > 0)
{
    qaliq = n % 10;

    n /= 10;

    if (Array.IndexOf(reqemler, qaliq) == -1)
    {
        size = reqemler.Length;
        Array.Resize(ref reqemler, size + 1);
        reqemler[size] = qaliq;
    }
}
Console.WriteLine(reqemler.Length);
foreach (var item in reqemler)
{
    Console.WriteLine(item);
}
return;





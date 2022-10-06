
//****************************************************************************************************************
//****Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.***
//****************************************************************************************************************
/*
int revnumber(int number)
{
int rnum=0;
int tmp=number;
while (tmp > 0)
{
    rnum=rnum*10+tmp%10;
    tmp=tmp/10;
}
return rnum;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()); 
int rnum = revnumber(num);

if (rnum == num) 
    Console.Write($"Число {num} является палиндромом");
else  
    Console.Write($"Число {num} не является палиндромом");

*/

//****************************************************************************************************************************
//***Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.***
//****************************************************************************************************************************

/*
double dist(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)  + Math.Pow((z2-z1),2));
    return distance;
}

Console.WriteLine("Введите координаты точек ");
Console.Write("x1 = ");
double x1 = double.Parse(Console.ReadLine()); 
Console.Write("y1 = ");
double y1 = double.Parse(Console.ReadLine()); 
Console.Write("z1 = ");
double z1 = double.Parse(Console.ReadLine()); 
Console.Write("x2 = ");
double x2 = double.Parse(Console.ReadLine()); 
Console.Write("y2 = ");
double y2 = double.Parse(Console.ReadLine()); 
Console.Write("z2 = ");
double z2 = double.Parse(Console.ReadLine()); 

double distance = dist(x1,y1,z1,x2,y2,z2);
Console.Write($"Расстояние между точками А({x1};{y1};{z1}) и Б ({x2};{y2};{z2})  равно: {Math.Round(distance,2)}");
*/


//****************************************************************************************************
//***Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N***
//****************************************************************************************************

/*
double [] Gettablcube(int n)
{
    double[] tablecube = new double[n];
    for (int i = 0; i<n; i++)
    {
        tablecube[i] = Math.Pow(i+1,3);
    }
    return tablecube;
}

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine()); 

double[] result = Gettablcube(n);

for (int i = 0; i<n; i++)
{
    Console.Write($" {result[i]}");
}

*/


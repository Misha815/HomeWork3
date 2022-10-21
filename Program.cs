//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* int Palindrome(int number)
{
int revers = 0;

while(number > 0)
{
    revers *= 10;
    revers += number % 10;
    number /= 10;
}
return revers;

}
    Console.Write("Введите число: ");
int InpunNumer = int.Parse(Console.ReadLine());

if (InpunNumer > 99999 || InpunNumer < 10000) 
    Console.WriteLine("Данное число недопустимо");

else if (Palindrome(InpunNumer) == InpunNumer) 
    Console.WriteLine("да");

else if (Palindrome(InpunNumer) != InpunNumer)
    Console.WriteLine("Нет");
 */
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. A (3,6,8); B (2,1,-7), -> 15.84

/* double Cord3D(int xa,int ya,int za, int xb, int yb, int zb)
{
double result = Math.Sqrt(((xb - xa)*(xb - xa))+((yb -ya)*(yb - ya))+((zb - za)*(zb - za)));

return result;
}
Console.WriteLine("Введите координаты для 2-х точек >>>");

Console.WriteLine("Введите x1:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1:");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2:");
int n6 = Convert.ToInt32(Console.ReadLine());

double resultCord =  Cord3D(n1,n2,n3,n4,n5,n6);

Console.WriteLine(Math.Round(resultCord,2)); */

//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* void Quadro(int num){

    for(int i = 0; i < num; i++)
    {
Console.Write($"{i*i*i} ");
    }
    
}
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Введите число:");

int result = Convert.ToInt32(Console.ReadLine());

Quadro(result); */
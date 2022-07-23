//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.


int A;
Console.WriteLine("Введите число A: ");
A = Convert.ToInt32(Console.ReadLine());
int sum = A%10;
while (A > 0)
{ 
   A = A/10;
   sum = sum + A%10;
}
{
   Console.WriteLine (sum);
}


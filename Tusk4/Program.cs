/* 
Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
*/

Console.WriteLine("Введите три числа ");

int firstNumb = int.Parse(Console.ReadLine());
int secondNumb = int.Parse(Console.ReadLine());
int thirdNumb = int.Parse(Console.ReadLine());
int max = firstNumb;

if (max < secondNumb) max = secondNumb;
if (max < thirdNumb) max = thirdNumb;

Console.Write("Максимальное число " + max);


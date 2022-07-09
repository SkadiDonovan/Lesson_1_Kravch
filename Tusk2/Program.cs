/* 
Напишите программу, которая на вход принимает два числа 
и выдаёт, какое число большее, а какое меньшее. 
*/
Console.WriteLine("Введите два числа ");

int firstNumb = int.Parse(Console.ReadLine());
int secondNumb = int.Parse(Console.ReadLine());

if (firstNumb > secondNumb) Console.Write("Число " + firstNumb + " больше " + secondNumb);

if (firstNumb < secondNumb) Console.Write("Число " + secondNumb + " больше " + firstNumb);

if (firstNumb == secondNumb) Console.Write("Числа равны");

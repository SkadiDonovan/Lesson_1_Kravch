/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/

Console.Write("Введите число ");

int number = int.Parse(Console.ReadLine());

for (int counter = 1; counter <= number; counter++){
    if (counter % 2 == 0) Console.Write(counter + " ");
}

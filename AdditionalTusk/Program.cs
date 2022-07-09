/*
На семинаре дали задачу на нахождение последнего числа
в трехзначном числе используя только математику (без парсинга числа и т.д.)
*/

Console.Write("Введите трехзначное число ");

bool enterCorrectNumber = true;
int number = 0;
int lastNumber = 0;

while (enterCorrectNumber){
    number = int.Parse(Console.ReadLine());
    if (number > 99){
        enterCorrectNumber = false;
        break;
    } 
    Console.Write("Введенное число не трехзначное. Попробуйте еще раз ");
}

lastNumber = number;

while (lastNumber >= 10){
    lastNumber -= 10;
}

Console.Write("Последнее число в " + number + " это " + lastNumber);

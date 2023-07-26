// Задача №1. 
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Задача №1.");
Console.WriteLine("Введите число а:");
int a1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите число b:");
int b1 = Convert.ToInt32(Console.ReadLine ());
int max = a1; 
if (a1<b1) {max = b1;}
Console.WriteLine("Больше число из заданных: " + max);


// Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Задача №2. ");
Console.WriteLine("Введите первое число:");
int a2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine("Введите второе число:");
int b2 = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine("Введите третье число:");
int c2 = Convert.ToInt32(Console.ReadLine ());
int max2 = a2; 
if (b2>max2){
    max2 = b2;
    }
if (c2>max2){
    max2 = c2;
}

Console.WriteLine("Больше число из заданных: " + max2);


// Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Задача №3. ");
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine ());
string parity = "Нечетное";
if (num%2==0){
parity = "Четное";
}
Console.WriteLine("Заданное число: " + parity);


// Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.WriteLine("Задача №4.");
Console.WriteLine("Введите число:");
int num2 = Convert.ToInt32(Console.ReadLine ());
int result = 2;
if (num2>=2){
Console.WriteLine("Все четные числа от 1 до " + num2 + ":");}
else {Console.WriteLine("Четные числа от 1 до " + num2 + " отсутствуют!");}
if (result <= num2) {
    Console.WriteLine(result);
    result = result + 2;      
}





Console.Clear();
Console.Write("ВВедите число:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
int a = 7;
int b = 23;
string result;
if (num1 % a == 0 && num1 % b == 0)  
result = ("Кратно обоим числам");
else if (num1 % a != 0 && num1 % b != 0)
result = ("Не кратно ни одному из чисел");
else if (num1 % a == 0)
result = ($"Кратно только числу {a}");
else result = ($"Кратно только числу {b}");

Console.WriteLine($"Проверить кратность чисел {num1} числам {a} и {b}");
Console.WriteLine();
Console.WriteLine($"Числа {num1} {result}");
Console.WriteLine();

// **Задача 14:**

// Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.
//if((a > b || a < c) && (x > b || x < c) || d == 5) <=> 0 && 1 || d == 5
//     0    +    0          1    +   0
 //         0          *         1
 //                    0                   +   1
 //                                1    
// 14  ->  нет
// 46  ->  нет
// 161 ->  да
Console.Clear();
Console.WriteLine();
int num1 = new Random().Next(11, 101);
int num2 = new Random().Next(1, 11);
int result = 0;
int mnumber(){
    result = num1 % num2;
    return result;
}
mnumber();
Console.WriteLine();
if (result == 0) Console.WriteLine($"Число {num1} кратно  {num2}");
else{
    Console.WriteLine($"Число {num1} не кратно {num2}, остаток равен {num1 % num2}");
}
Console.WriteLine();


/*12 Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно
*/
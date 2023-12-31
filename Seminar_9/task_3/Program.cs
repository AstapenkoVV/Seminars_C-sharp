﻿/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два 
неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int WorkWithUser(string message)
{
    Console.Write(message + " ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

int AkkermanFun(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanFun(m - 1, 1);
    else
      return AkkermanFun(m - 1, AkkermanFun(m, n - 1));
}

int m = WorkWithUser("Введите наименьшее число M: ");
int n = WorkWithUser("Введите наибольшее число N: ");
Console.WriteLine($"A({m},{n}) = {AkkermanFun(m, n)}");
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите размер массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[numbers];

void PrintNumbers(int numbers)
{
  for (int i = 0; i < numbers; i++)
  {
      Console.Write($"Введите число номер {i+1}: ");
      arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
PrintNumbers(numbers);
int Sum(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
Console.WriteLine($"Вы ввели {Sum(arrayNumbers)} чисел больше 0");
// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
 
//массив
int[] myArray = new int[4];
 
//метод заполнения
Random rand = new Random();
 
//заполнение массива через цикл
 
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = rand.Next(1, 10);
    Console.Write(myArray[i] + ", ");
}
 
// 1 способ:
// int maxValue = myArray[0];
// int minValue = myArray[0];
 
// for (int i = 1; i < myArray.Length; i++)
// {
//     if (myArray[i] < minValue)
//     minValue = myArray[i];
//     if (myArray[i] > maxValue)
//       maxValue = myArray[i];
// }
// Console.WriteLine();
// Console.WriteLine($"max: {maxValue}");
// Console.WriteLine($"min: {minValue}");
// int differense = maxValue-minValue;
// Console.WriteLine($"Разница: {differense}");
 
//2 способ:
int maxValue = myArray.Max();
int minValue = myArray.Min();
int diff = maxValue - minValue;
Console.WriteLine();
Console.WriteLine($"max: {maxValue}");
Console.WriteLine($"min: {minValue}");
Console.WriteLine($"Разница: {diff}");

// // Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

//массив
int[] myArr = new int[4];
var rnd = new Random();
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = rnd.Next(0, 10);
    Console.Write($"{myArr[i]}" + ", ");

}
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < myArr.Length; i++)
{
    if (i % 2 == 0)
        sum1 = sum1 + myArr[i];
            else
        sum2 = sum2 + myArr[i];

}
Console.WriteLine($"\n Сумма элементовб стоящих на чётных позициях: {sum1} \n Сумма элементовб стоящих на нечётных позициях: {sum2}");




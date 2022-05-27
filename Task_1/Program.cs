// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2

//массив
int[] myArray = new int[4];

//метод заполнения
Random rand = new Random();

//заполнение массива через цикл
for (int i = 0; i < 4 ; i++)
{
    myArray[i] = rand.Next(101, 999);
    Console.Write(myArray[i] + ", ");

}

int count = 0;
for (int i = 0; i < 4 ; i++)
{
    if(myArray[i] % 2 == 0)
    count++;
}
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел : {count}");


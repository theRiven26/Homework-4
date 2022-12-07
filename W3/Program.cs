/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


Console.Write("Enter lenght array: ");
int lenght = int.Parse(Console.ReadLine());
int[] array = FillArray(lenght); 
PrintArray(array);


int[] FillArray(int countIndex)
{
	Random random = new Random();
	int[] array = new int[countIndex];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.Next(0, 100);
	}
	return array;
}

void PrintArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
}
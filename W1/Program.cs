/* Задача 25: Напишите программу, которая принимает на вход два чила (A и B) и метод который возводит число A в натуральную степень B.
 Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow() */
Console.Write("Enter number: ");
 int num = int.Parse(Console.ReadLine());

Console.Write("Enter degree of number: ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"{num} ^ {degree} = {GetNumberToTheDegree(num, degree)}");

int GetNumberToTheDegree(int num, int degree)
{
	int result = num;
	for (int i = 1; i < degree; i++)
	{
		result = result * num;
	}
	return result;
}

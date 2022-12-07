/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetSumNumberOfNumber(num)}");

int GetSumNumberOfNumber(int number)
{
	int sum = 0;
	do
	{
		sum = sum + SplitNumberIntiDigits(number, out int n);
		number = n;
	}
	while (number > 0);
	return sum;
}

int SplitNumberIntiDigits(int number, out int n)
{
	int result = 0;
	result = number % 10;
	n = number / 10;
	return result;
}
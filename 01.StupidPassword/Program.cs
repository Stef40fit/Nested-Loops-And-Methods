//Write a program that:
//•	Reads an integer number N from the console
//•	Generates all possible passwords consisting of the following 3 parts:
//o The first part is an even number in the range [2…N]
//o The second digit is an odd number in the range [1…N]
//o The third is the product of the first two
//•	The output holds all possible passwords

int N = int.Parse(Console.ReadLine());

for (int first = 2; first <= N; first += 2)
{
    for (int second = 1; second <= N; second += 2)
    {
        Console.Write($"{first}{second}{first * second} ");
    }
}

//Write a program that:
//•	Reads an integer number N from the console
//•	Find all 3-digit magic numbers
//Note: A magic number is a three-digit number where the product of its digits equals the value of N.
//    If you have a three-digit number abc, where a, b and c are its digits, it is considered a magic number of order N,
//    if a * b * c = N.


int N = int.Parse(Console.ReadLine());

for  (int digit1 = 1; digit1 <= 9; digit1 ++)
{
    for (int digit2 = 0; digit2 <= 9; digit2++)
    {
        for (int digit3 = 0; digit3 <= 9; digit3++)
        {
           if (digit1 * digit2 * digit3 == N)
            {
                Console.Write($"{digit1}{digit2}{digit3} ");
            }
            
        }
    }
}

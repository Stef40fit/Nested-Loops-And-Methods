//Write a program to generate PIN codes following certain rules:
//•	Read 3 integer digits: max1, max2, max3 (each is an upper limit)
//•	Generate unique 3-digit PIN codes, matching the following:
//o Each digit is within the following range: 
//	Firstdigit: [1 … max1]
//	Seconddigit: [1 … max2]
//	Thirddigit: [1 … max3]
//o The first and the third digit must be even
//o	The second digit must be a prime number in the range [2…7]
//•	Print the PIN codes, each on separate line

int max1 = int.Parse(Console.ReadLine());
int max2 = int.Parse(Console.ReadLine());
int max3 = int.Parse(Console.ReadLine());

for  (int Firstdigit = 2; Firstdigit <= max1; Firstdigit += 2)
{
    for (int Seconddigit = 1; Seconddigit <= max2; Seconddigit ++)
    {
        for (int Thirddigit = 2; Thirddigit <= max3; Thirddigit += 2)
        {
            if (Seconddigit==2 || Seconddigit == 3 || Seconddigit == 5 || Seconddigit == 7)
            {
                Console.WriteLine($"{Firstdigit}{Seconddigit}{Thirddigit}");
            }
        }
    }
}
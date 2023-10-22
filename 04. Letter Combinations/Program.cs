//Write a program to generate 3-letter combinations under certain conditions:
//•	Read a start letter s, end letter e and excluded letter x
//•	Generate all combinations of 3 letters in the range [s…e], excluding x
//•	Print all combinations on the first line
//•	Print combinations count on the second line




char startLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());
char excludLetter = char.Parse(Console.ReadLine());

int sumCombinations = 0;
for (char letter1 = startLetter; letter1 <= endLetter ; letter1++)
{
    for (char letter2 = startLetter; letter2 <= endLetter ; letter2++)
    {
        for (char letter3 = startLetter; letter3 <= endLetter ; letter3++)
        {

            
            if (letter1 != excludLetter && letter2 != excludLetter && letter3 != excludLetter)
            {
                Console.Write($"{letter1}{letter2}{letter3} ");
                sumCombinations += 1;
            }
            
            

        }

    }
    
}
Console.WriteLine();
Console.WriteLine(sumCombinations);
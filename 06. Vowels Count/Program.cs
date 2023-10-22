//Write a program that:
//•	Read a text (string) from the console
//•	Create a method that receives a text
//•	Find the count of the vowels contained in the text
////•	Print the count of the vowels in the text

string text = Console.ReadLine();
Console.WriteLine(GetVolwesCount(text));
static int GetVolwesCount(string text)
{
    int count = 0;
    for(int position = 0; position < text.Length; position++)
    {
        char symbol = text[position];
        if (symbol ==  'A' || symbol == 'a' || symbol == 'E' || symbol == 'e' 
            || symbol == 'I' || symbol == 'i' || symbol == 'U' || symbol == 'u' 
            || symbol == 'O' || symbol == 'o')
        {
        count ++;
        }
    }
    return count;
}


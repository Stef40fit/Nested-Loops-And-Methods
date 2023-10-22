//•	Reads three integer numbers (num1, num2 and num3) from the console
//•	 Finds if num1 * num2 * num3 (the product) is negative, positive or zero
//•	Print:
//o negative - if the product is smaller than 0 
//o	positive - if the product is bigger than 0
//o	zero - if the product is equals to 0
//Note: Try to do this WITHOUT multiplying the three numbers.

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

PrintSign(num1, num2, num3);
//1 nachin

static void PrintSign(int n1, int n2, int n3)
{
    //    int product = n1 * n2 * n3;
    //    if  (product < 0)
    //    {
    //        Console.WriteLine("negative");
    //    }
    //    else if (product > 0)
    //    {
    //        Console.WriteLine("positive");
    //    }
    //    else
    //    {
    //        Console.WriteLine("zero");
    //    }

    //2 nachin
    if (n1 == 0 || n2 == 0 || n3 == 0)
    {
        Console.WriteLine("zero");
    }
    else if (n1 > 0 && n2 > 0 && n3 > 0) 
    {
        Console.WriteLine("positive");
    }
    else if (n1 > 0 && n2 < 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 < 0 && n2 < 0 && n3 > 0)
    {
        Console.WriteLine("positive");
    }
    else if (n1 < 0 && n2 > 0 && n3 < 0)
    {
        Console.WriteLine("positive");
    }
    else
    {
        Console.WriteLine("negative");
    }
}


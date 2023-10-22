//•	Read two integers numbers from the console
//•	Calculate the factorial of each number
//•	Divide the first calculated factorial by the second calculated factorial
//•	Print the result of the division

//ВАРИАНТ 1

//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine(ResultFactDivision(num1,num2));
//static double ResultFactDivision(int num1,int num2)
//{
//    long fact1 = 1;
//    long fact2 = 1;
//    double division = 0;
//    for (int coun1 = 1; coun1 <= num1; coun1++)
//    {
//        fact1 *= coun1;
//    }
//    for (int coun2 = 1; coun2 <= num2; coun2++)
//    {
//        fact2 *= coun2;
//    }
//    division =  fact1 / fact2;
//    return division;
//}

//ВАРИАНТ 2

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int factoriel1 = ResultFactDivision(num1);
int factoriel2 = ResultFactDivision(num2);

Console.WriteLine(factoriel1 / factoriel2);

static int ResultFactDivision(int num)
{
    int fact = 1;       
    for (int coun = 1; coun <= num; coun++)
    {
        fact *= coun;
    }   
    return fact;
}






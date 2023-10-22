////Write a program that checks if a given password is valid.
////The password validation rules are:
////•	It should contain 6 – 10 characters (inclusive)
////•	It should contain only letters and digits
////•	It should contain at least 2 digits 
////If it is not valid, for any unfulfilled rule print the corresponding message:
////•	"Password must be between 6 and 10 characters"
////•	"Password must consist only of letters and digits"
////•	"Password must have at least 2 digits"

string password = Console.ReadLine();

        bool isValidLength = password.Length >= 6 && password.Length <= 10;
        bool isValidContent = CheckContent(password);
        bool isValidCountDigits = CheckCountDigits(password);

        if (isValidLength && isValidContent && isValidCountDigits)
        {
            Console.WriteLine("Password is valid");
        }
        else
        {
            if (!isValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isValidContent)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isValidCountDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }


static bool CheckContent(string password)
{
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];

        if (char.IsLetterOrDigit(symbol) == false)
        {
            return false; //прекъсва метода и дава резултат от него false
        }
    }

    return true;
}

static bool CheckCountDigits(string password)
{
    int count = 0; //брой на цифрите
    for (int position = 0; position <= password.Length - 1; position++)
    {
        char symbol = password[position];

        if (char.IsDigit(symbol) == true)
        {
            count++;
        }
    }

    return count >= 2;
} //false -> подадения символ не е цифра@

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Console.Write("Please enter your name. ");
string? name = Console.ReadLine();

bool tryAgain = true;

while (tryAgain)
{
    Console.Write($"Welcome to Number Analyzer, {name}!. Please enter a number between 1 and 100 inclusive. ");
    int num = int.Parse(Console.ReadLine());
    //Console.WriteLine(num);

    if (num >= 1 && num <= 100)
    {
        bool isEven = num % 2 == 0;

        if (isEven)
        {
            if (num >= 2 && num <= 24)
            {
                Console.WriteLine($"{name}, the number you entered is Even and less than 25.");
            }
            else if (num >= 26 && num <= 60)
            {
                Console.WriteLine($"{name}, the number you entered is Even and between 26 and 60 inclusive.");
            }
            else
            {
                Console.WriteLine($"{name}, the number you entered is Even and greater than 60.");
            }
            //Console.WriteLine("hi");
        }
        else
        {
            if (num <= 60)
            {
                Console.WriteLine($"{name}, the number you entered is Odd and less than 60.");
            }
            else
            {
                Console.WriteLine($"{name}, the number you entered is Odd and greater than 60.");
            }
        }
    }
    else
    {
        Console.WriteLine($"{name}, the number you entered is not between 1 and 100.");
    }

    Console.Write($"Would you like to try again {name}? Y/N  ");
    string? yesNo = Console.ReadLine();

    if (yesNo?.ToLower() == "n")
    {
        tryAgain = false;
        Console.WriteLine($"{name}, you can stop. Good bye!.");
    }
    else if (yesNo?.ToLower() == "y")
    {
        tryAgain = true;

    }
    else if (yesNo?.ToLower() != "y" || yesNo?.ToLower() != "n")
    {
        //tryAgain = false;
        Console.WriteLine($"Please select Y/N ");
        tryAgain = false;
    }
}




//Console.Write("Please enter your name. ");
//string? name = Console.ReadLine();


//Console.Write($"Welcome to Number Analyzer, {name}!. Please enter a number between 1 and 100 inclusive. ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine(num);

//if (num >= 1 && num <= 100)
//{
//    bool isEven = num % 2 == 0;

//    if (isEven)
//    {
//        if (num >= 2 && num <= 24)
//        {
//            Console.WriteLine($"{name}, the number you entered is Even and less than 25.");
//        }
//        else if (num >= 26 && num <= 60)
//        {
//            Console.WriteLine($"{name}, the number you entered is Even and between 26 and 60 inclusive.");
//        }
//        else
//        {
//            Console.WriteLine($"{name}, the number you entered is Even and greater than 60.");
//        }
//        //Console.WriteLine("hi");
//    }
//    else
//    {
//        if (num <= 60)
//        {
//            Console.WriteLine($"{name}, the number you entered is Odd and less than 60.");
//        }
//        else
//        {
//            Console.WriteLine($"{name}, the number you entered is Odd and greater than 60.");
//        }
//    }
//}
//else
//{
//    Console.WriteLine($"{name}, the number you entered is not between 1 and 100.");
//}


//Console.Write("Wouls you like to try again? Y/N  ");
//string? input = Console.ReadLine();

//if (input?.ToLower() == "n")
//{
//    Console.WriteLine($"{name}, you can stop. Good bye!.");
//}
//else
//{
//    Console.WriteLine($"{name}, you can start again.");
//}

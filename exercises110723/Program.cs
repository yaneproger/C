//new exercises130722
//start new program
int input(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void NumberCheck(int arg1)
{
    if (arg1 %2==0)
    {
        Console.WriteLine("the number is even");
    }
    else 
    {
        Console.WriteLine("the number is odd");
    }
}

int numcheck=input("enter a number");
NumberCheck(numcheck);

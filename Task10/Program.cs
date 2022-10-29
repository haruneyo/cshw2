int secondDigit(int x)
{
    int digit = x / 10;
    int secondD = digit % 10;
    return secondD;
}

int num = new Random().Next(100, 1000);
System.Console.WriteLine("The number is: " + num);
System.Console.WriteLine("The second digit of the number is: " + secondDigit(num));
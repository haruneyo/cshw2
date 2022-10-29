System.Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());

int findThirdDigit(int input)
{
    int newNum = input / 100;
    int thirdD = newNum % 10;
    return thirdD;
}

if (num < 100 && num > -100) System.Console.WriteLine("The number is less than three digits");
else System.Console.WriteLine(findThirdDigit(num));
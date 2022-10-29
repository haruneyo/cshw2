System.Console.WriteLine("Please enter the number of the day of the week:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 || num > 7) System.Console.WriteLine("This day of the week does not exist");
else System.Console.WriteLine("Is it the weekend? --> " + weekendCheck(num));

bool weekendCheck(int num)
{
    if (num == 6 || num == 7) return true;
    else return false;
}
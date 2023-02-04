// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine ("Введите число: ");
int numb = Convert.ToInt32 (Console.ReadLine());
{
    int sum = 0;
    int result = 0;
    while (numb > 0)
    {
        sum = numb % 10;
        numb = numb / 10;
        result = result + sum;
    }
    System.Console.WriteLine(result);
}


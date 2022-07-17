// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    String a_String = Console.ReadLine();
    return int.Parse(a_String);
}

void PrintNaturalNumbers(int numberM, int numberN)
{
    if (numberM > numberN) return;

    if (numberN % 2 == 1)
    {
        numberN--;
    }

    PrintNaturalNumbers(numberM, numberN-2);

    if (numberN%2==0) System.Console.Write($"{numberN}; ");

}

int numberM = Prompt("Введите число m: ");
int numberN = Prompt("Введите число n: ");

System.Console.WriteLine();

System.Console.Write($"M = {numberM}, N = {numberN} -> ");
PrintNaturalNumbers(numberM, numberN);
System.Console.WriteLine();
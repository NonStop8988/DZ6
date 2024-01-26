// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Функция - проверка строки на палиндромность
void PrintPalindromeString(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            Console.Write("Введенная строка НЕ является палиндромом");
            break;
        }
        else if (str[i] == str[str.Length - 1 - i] && i == str.Length / 2 - 1)
        {
            Console.Write("Введенная строка ЯВЛЯЕТСЯ палиндромом");
        }
    }
}

// Console.Clear();
Console.Write("Введите строку, чтобы проверить, является ли она палиндромом: ");
string str = Console.ReadLine()!;
string lowerCaseString  = str.ToLower();
PrintPalindromeString(lowerCaseString);
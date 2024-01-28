// Задача 4*. Задайте строку, состоящую из слов, разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

Console.Clear();
string input = "Hello my world";
string[] arrayWordsInput = input.Split(' ');
string temp = "";
for (int i = 0; i < arrayWordsInput.Length / 2; i++)
{
    temp =  arrayWordsInput[i];
    arrayWordsInput[i] = arrayWordsInput[arrayWordsInput.Length - i - 1];
    arrayWordsInput[arrayWordsInput.Length - i - 1] = temp;
}
Console.WriteLine($"{string.Join(" ", arrayWordsInput)}");
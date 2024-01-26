// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
Console.Clear();
string originalString  = "aBcD1ef!-";
Console.WriteLine($"Изначальная строка: {originalString}");
string lowerCaseString  = originalString.ToLower();
Console.WriteLine($"Строка с измененным регистром символа: {lowerCaseString}");
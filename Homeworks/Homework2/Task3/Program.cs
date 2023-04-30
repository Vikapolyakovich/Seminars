int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int number) {
if (number == 6 || number ==7 ) {
    Console.WriteLine($"{number}->да");
    return true;
}
Console.WriteLine($"{number}-> нет");
return false;
}

int number = Prompt("Введите число: ");
ValidateNumber(number);
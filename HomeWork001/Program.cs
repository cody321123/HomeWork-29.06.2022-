void checkNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
       Console.WriteLine("Да"); 
    }
    else
    {
        Console.WriteLine("Нет");
    }

    
}

Console.WriteLine("Введите 5 значное число");

string number = Console.ReadLine();

checkNumber(number);
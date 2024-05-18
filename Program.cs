string[] IncomeArray = new string[8] {"1234", "1567", "-2", "computer science", "Hello", "2", "world", ":-)"};                    // Задание входного массива строк
string[] OutputArray = new string[IncomeArray.Length];                                              // Выходной такой же длины
void FillArray(string[] IncomeArray, string[] OutputArray)                                          // Метод заполнения выходного массиива значениями из входного при условии 
{
    int CounetrOutputArray = 0;
    for (int CounetrIncomeArray = 0; CounetrIncomeArray < IncomeArray.Length; CounetrIncomeArray++)
    {
    if(IncomeArray[CounetrIncomeArray].Length <= 3)                                                 // Условие выбора подходящих значений (длина строки меньше 3 символов)
        {
        OutputArray[CounetrOutputArray] = IncomeArray[CounetrIncomeArray];
        CounetrOutputArray++;
        }
    }
}   
void PrintArray(string[] array)                                                                     // Метод вывода на экран строкового массива 
{
    for (int CounetrIncomeArray = 0; CounetrIncomeArray < array.Length; CounetrIncomeArray++)
    {
        Console.Write($"{array[CounetrIncomeArray]} ");
    }
    Console.WriteLine();
}

FillArray(IncomeArray, OutputArray);
PrintArray(OutputArray);
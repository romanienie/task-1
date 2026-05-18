using System; // подключение библиотеки

class Program1 // объявление класса
{
    static void Main() // точка входа
    {
        Console.Write("введите число x (не меньше 100): "); // вывод текста
        string input = Console.ReadLine(); // сохранение в переменную

        // защита 1: проверка на пустую строку
        if (string.IsNullOrEmpty(input)) // проверка условия
        {
            Console.WriteLine("ошибка: вы ничего не ввели!");
            return;
        }

        // защита 2: проверка на то, что введены только цыфры
        foreach (char c in input) // цыкл
        {
            if (!char.IsDigit(c)) // проверка условия
            {
                Console.WriteLine("ошибка: можно вводить только цифры!");
                return;
            }
        }

        // защита 3: проверка на большое количество цыфр
        // ограничение цыфр 10
        if (input.Length > 10) // проверка условия
        {
            Console.WriteLine("ошибка: число слишком длинное! максимум 10 цифр.");
            Console.WriteLine($"вы ввели {input.Length} цифр, а можно не больше 10.");
            return;
        }

        // защита 4: проверяем, что число не меньше 100
        int x = int.Parse(input);
        if (x < 100) // проверка условия
        {
            Console.WriteLine("ошибка: число должно быть не меньше 100!");
            Console.WriteLine($"вы ввели {x}, а нужно 100 или больше.");
            return;
        }

        // защита 5: дополнительная защита от переполнения
        // (на случай больших чисел)
        try // обработка
        {
            string xStr = x.ToString();

            // проверяем, что в числе больше двух цифр
            if (xStr.Length < 3) // проверка условия
            {
                Console.WriteLine("ошибка: в числе должно быть больше двух цифр!");
                return;
            }

            char secondDigit = xStr[1];
            string afterRemove = xStr[0] + xStr.Substring(2);
            string resultStr = afterRemove + secondDigit;

            // защита 6: проверяем, что результат не вызовет переполнение
            // (результат может быть длиннее исходного числа)
            if (resultStr.Length > 10) // проверка условия
            {
                Console.WriteLine("ошибка: результат получился слишком длинным!");
                return;
            }

            int n = int.Parse(resultStr);

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"n = {n}");
        }
        catch (OverflowException) // не выполнение обработки
        {
            Console.WriteLine("ошибка: число слишком большое для программы!");
        }
    }
}
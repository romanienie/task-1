using System; // подключение библиотеки

class Task1Power // обозначение начала с наименованием кода
{
    static void Main() // точка входа в код
    {
        int a = 0;
        int n = 0;
        bool validInput = false;

        // защита для числа a (натуральное число)
        while (!validInput) // цикл
        {
            Console.Write("введи число а (натуральное число, например, 3): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out a) && a > 0) // условие
            {
                validInput = true;
            }
            else // не выполнение условия
            {
                Console.WriteLine("ошибка! введите натуральное число (целое, положительное, больше 0).");
            }
        }

        validInput = false;

        // защита для степени n (натуральное число)
        while (!validInput) // цикл
        {
            Console.Write("введи степень n (натуральное число, например, 4): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n > 0) // условие
            {
                validInput = true;
            }
            else // не выполнение условия
            {
                Console.WriteLine("ошибка! введите натуральное число (целое, положительное, больше 0).");
            }
        }

        int result = 1; // начинаем с 1

        // защита от переполнения (опционально)
        try // обработка
        {
            for (int i = 1; i <= n; i++) // цикл
            {
                result = result * a; // тело цикла

                // Проверка на переполнение (для int)
                if (result < 0 && i < n) // условие
                {
                    Console.WriteLine("внимание! переполнение, результат может быть некорректным.");
                }
            }

            Console.WriteLine(a + " в степени " + n + " = " + result); // ответ
        }
        catch (OverflowException) // не выполнение обработки
        {
            Console.WriteLine("ошибка! результат слишком большой для хранения в типе int.");
        }
    }
}

using System; // подключение библиотеки

class Task1Power // обозначение начала с наименованием кода

{ // относится к классу class Task1Power
    static void Main() // точка входа в код
    {
        Console.Write("Введи число а (например, 3): "); // просим ввести число
        int a = Convert.ToInt32(Console.ReadLine()); // ввод числа

        Console.Write("Введи степень n (например, 4):"); // просим ввести число
        int n = Convert.ToInt32(Console.ReadLine()); // ввод числа

        int result = 1; // начинаем с 1 по тому что если умножить на 0, то все сломается

        for (int i = 1; i <= n; i++) // цыкл
        {
            result = result * a; // тело цыкла
        }

        Console.WriteLine(a + " в степени " + n + " = " + result); // ответ
    }
}
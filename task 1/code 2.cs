using System;

class Program{

  static void Main(){

        Console.WriteLine ("Введите число x (не меньше 100): ");
        string input = Console.ReadLine();
        // protection 1 (empty string)
        if (string.IsNullOrEmpty(input)) {
            Console.WriteLine("Ошибка! введите значение, например 123");
            return;
        }
        // protection 2 (to numbers)
        foreach ( char c in input) {
          if (!char.IsDigit(c))
            {
                Console.WriteLine("Ошибка! введите только цифры, например 123");
                return;
            }
        }
        // protector 3 (digit limit 10)
        if (input.Length > 10)
        {
            Console.WriteLine("Ошибка! лимит цифр 10");
            return;
        }
        
        int xIndex = int.Parse(input);
        // protector 4 (number not less 100)
        if (xIndex < 100) {
            Console.WriteLine("Ошибка! число не менее 100, например 123");
            return;
        }
        // protector 5 (overfill protection)
        try
        {
            string xStr = xIndex.ToString();

            if (xStr.Length < 3)
            {
                Console.WriteLine("Ошибка! в числе не менее 3-ех цыфр");
                return;
            }

            char secondDigit = xStr[1];
            string afterRemove = xStr[0] + xStr.Substring(2);
            string resultStr = afterRemove + secondDigit;
            // protector 6 (don`t cause overflow)
            if (resultStr.Length > 10) {
                Console.WriteLine("Ошибка! результат слишком длинный");
                return;
            }

            int nIndex = int.Parse(resultStr);

            Console.WriteLine($"x = {input}\nn = {nIndex}");

        }
        catch (OverflowException){
            Console.WriteLine("Ошибка! число большое для программы");
        }

  }
}

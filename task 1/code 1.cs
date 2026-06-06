using System;

class Program{
  
  static void Main(){
    
      int aIndex = 0; // variable a
      int nIndex = 0; // variable n
      bool validInput = false; // variable for loop repetition

      // protection for number `a` (natural number)
      while (!validInput){

            Console.WriteLine("Введите число `a` ( натуральное число, например 3 )");
            string input = Console.ReadLine();
            
            // condition natural number
            if(int.TryParse(input, out aIndex)&& aIndex > 0){

              validInput = true;
            }
            else{

                Console.WriteLine("Ошибка! Введите натуральное число, например 3");
            }
        }

      // return value for proper operation
      validInput = false;

      // protection for number `n` (natural number)
      while (!validInput){

          Console.WriteLine("Введите степень n (натуральное число, например 3)");
          string input = Console.ReadLine() ;
          
          // condition natural number
          if (int.TryParse(input, out nIndex) && nIndex > 0){

              validInput = true;
            }
            else{

                Console.WriteLine("Ошибка! Ведите натуральное число, например 3");
            }
        }

      int result = 1;

      try{

          for(int iIndex = 1; iIndex <= nIndex; iIndex++){
              
                result = result * aIndex;

              if (result < 0 && iIndex < nIndex){

                    Console.WriteLine("Внимание! переполнение, результат может быть не корректным.");
                }
            }

            Console.WriteLine(aIndex + " в степени " + nIndex + " = " + result);

        }
        catch (OverflowException){
            
            Console.WriteLine("Ошибка! результат слишком большой для хранения в типе int.");
        }
        
    }
}

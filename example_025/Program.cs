// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


int Exponentiation(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
    // int result = Math.Pow(A, B);
    return result;
}

  Console.Write("Введите число: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите степень для числа: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(A, B);
  Console.WriteLine("Ответ: " + exponentiation);

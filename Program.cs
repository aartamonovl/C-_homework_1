//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first int number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second int number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber){
    Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
}
else if (firstNumber < secondNumber){
    Console.WriteLine($"{firstNumber} is less than {secondNumber}");
}
else {
    Console.WriteLine($"{firstNumber} is equal to the {secondNumber}");
}
//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Input first int number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber){
    Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
}
else if (firstNumber < secondNumber){
    Console.WriteLine($"{firstNumber} is less than {secondNumber}");
}
else {
    Console.WriteLine($"{firstNumber} is equal to the {secondNumber}");
}*/

//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Input first int number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second int number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third int number: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (secondNumber > firstNumber){
    if (thirdNumber > secondNumber){
        Console.WriteLine($"{thirdNumber} is the largest number.");
    }
    else{
        Console.WriteLine($"{secondNumber} is the largest number.");
    }
}
else if (thirdNumber > firstNumber){
    Console.WriteLine($"{thirdNumber} is the largest number.");
}
else{
    Console.WriteLine($"{firstNumber} is the largest number.");
}*/

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.Write("Input int number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0){
    Console.WriteLine($"Yes, the number '{number}' is even");
}
else{
    Console.WriteLine($"No, the number '{number}' is not even");
}*/

//Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//Использовал дополнительное условие, чтобы в конце строки вывода была не запятая, а точка.

/*Console.Write("Input natural number: ");
int naturalNumber = Convert.ToInt32(Console.ReadLine());

if (naturalNumber > 1){
    for (int number = 2; naturalNumber - 2 >= number; number = number + 2){
       Console.Write($"{number}, ");
    }
    if (naturalNumber % 2 == 0){
        Console.Write($"{naturalNumber}.");
    }
    else{
        Console.Write($"{naturalNumber - 1}.");
    }
}
else{
    Console.WriteLine("There is no one even number. Try again.");
}
Console.WriteLine("");*/
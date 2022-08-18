Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[5] ||  number[1]==number[4] || number[2]==number[3] ){
    Console.WriteLine($"Введеное число: {number} - палиндром.");
  }
  else Console.WriteLine($"Введеное число: {number} - НЕ палиндром.");
}

if (number!.Length == 6){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");

Console.Write("Введите число: ");
string number = Console.ReadLine();

void palindr(string number){
  if (number[0]==number[4] || number[1]==number[3])
    Console.WriteLine("палиндром.");
  else Console.WriteLine("не палиндром.");
}

if (number.Length == 5)
  palindr(number);
else Console.WriteLine("Введите число с 5 символами");
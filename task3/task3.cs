Console.Clear();
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index <= cube){
    int number = index*index*index;
    Console.WriteLine($"{number}");
    index++;
}
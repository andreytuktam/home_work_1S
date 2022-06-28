Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC ){
    Console.Write("max=");
    Console.Write(numberA);
}if (numberB > numberA && numberB > numberC ){
    Console.Write("max=");
    Console.Write(numberB);
}if (numberC > numberA && numberC > numberB ){
    Console.Write("max=");
    Console.Write(numberC);
}


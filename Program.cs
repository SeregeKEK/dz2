void Zadacha1(){
    //Random rand = new Random();
    //int number = rand.Next(10000, 100000);
    Console.WriteLine("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int a = number / 10000;
    int b = (number / 1000) % 10;
    int c = (number / 100) % 10;
    int d = (number / 10) % 10;
    int e = number % 10;
    if(a == e && b == d){
        Console.WriteLine("Число является палиндромом");
    }
    else Console.WriteLine("Число НЕ является палиндромом");
}

void Zadacha2(){
    Console.WriteLine("Введите число x1: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число x2: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y1: ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число y2: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число z1: ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число z2: ");
    int z2 = Convert.ToInt32(Console.ReadLine());
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    Console.WriteLine($"Расстояние между точками {result}");

}
void Zadacha3(){
    Console.WriteLine("Введите число");
    int number = Convert.ToInt16(Console.ReadLine());
    int startNumber = 0;
    while(number != startNumber){
        startNumber+=1;
        Console.WriteLine(startNumber + "^3 = " + Math.Pow(startNumber, 3));
    }
}

Zadacha3();
//Zadacha2();
//Zadacha1();



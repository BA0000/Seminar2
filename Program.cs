int Znach3()
{
    int rand = new Random().next(100, 1000);
    Console.WriteLine("rand number is " + rand);
    int FirstNumber = rand / 100;
    int LustNumber = rand % 10;
    int result = FirstNumber * 10 + LustNumber;
    Console.WriteLine(result);
    return result;
}

Znach3();
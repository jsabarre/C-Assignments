//Question1
for (int i = 1; i <= 100; i++)
{
    if (i % 15 == 0)
    {
        Console.Write("FizzBuzz, ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz, ");
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz, ");
    }
    else
    {
        Console.Write(i + ", ");
    }
};
Console.Write("\n");

Console.Write("\n");



//Question2
for (int i = 1; i <= 5; i++)
{
    for (int space = 1; space <= 5 - i; space++)
    {
        Console.Write(" ");
    }
    for (int star = 1; star <= 2 * i - 1; star++)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}
Console.Write("\n");



//Question3
Random r = new Random();

int num = r.Next(0, 4);

Console.Write("\n Guess a number between 1 and 3: ");
int guess = int.Parse(Console.ReadLine());

if (guess == num)
{
    Console.WriteLine("Correct Answer!");
}
if (guess > num)
{
    Console.WriteLine("Your guess is too High!");
}
if (guess < num)
{
    Console.WriteLine("Your guess is too Low!");
}



//Question 4
DateTime timeNow = DateTime.Today;

Console.Write("Enter the Day when you were born: ");

int Day = int.Parse(Console.ReadLine());

Console.Write("Enter the Month when you were born: ");

int Month = int.Parse(Console.ReadLine());

Console.Write("Enter the Year when you were born: ");

int Year = int.Parse(Console.ReadLine());

DateTime Birthday = new DateTime(Year, Month, Day);

double difference = (timeNow - Birthday).TotalDays;


Console.WriteLine($"You are this many days old : " + difference + " Days");

double Anniversary = 10000 - (difference % 10000);

Console.WriteLine($"You have " + Anniversary + " This many days left until next 10,000 day Anniversary!");

//Question 5

DateTime DateTimeNow = DateTime.Now;

int HourNow = DateTimeNow.Hour;
int Morning = 5;
int Afternoon = 12;
int Evening = 17;
int Night = 20;

if (Morning <= HourNow && HourNow < Afternoon)
{
    Console.WriteLine("/nGood Morning");
};

if (Afternoon <= HourNow && HourNow < Evening)
{
    Console.WriteLine("/nGood Afternoon!");
};

if (Evening <= HourNow && HourNow < Night)
{
    Console.WriteLine("/nGood Evening!");
};

if (Night <= HourNow || HourNow < Morning)
{
    Console.WriteLine("/nGood Night!");
};

//Question6
for (int i = 1; i <= 4; i += 1)
{
    for (int j = 0; j <= 24; j += i)
    {
        Console.Write($" " + j + ",");

    }

    Console.WriteLine();
}
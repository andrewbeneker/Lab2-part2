
    bool keypadLock = false;
    int tryCounter = 1;
Console.WriteLine("You have 5 tries to get the combination right before it locks up.");
Console.WriteLine();
do
{
    Console.WriteLine("Please enter the combination.");
    int comboGuess = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (comboGuess == 2345)
    {

        Console.WriteLine("Welcome.");
        break;

    }
    else
    {

        Console.WriteLine("Incorrect combination.");
        tryCounter++;
        if (tryCounter > 5)
        {
            Console.WriteLine("Too many tries. You've been locked out.");
            break;
        }


    }


}
while (keypadLock == false);



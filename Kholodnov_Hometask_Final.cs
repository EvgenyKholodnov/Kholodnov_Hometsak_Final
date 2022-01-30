void Introduction() //Introduction
{
    Console.WriteLine();
    Console.WriteLine("Aloha, my dear friend!");
    Console.WriteLine("Let me introduce myself first:");
    Console.WriteLine("My name is Evgeny Kholodnov.");
    Console.WriteLine("You can contact me via evgenykholodnov@yandex.ru");
    Console.WriteLine("Or via @evgeny_kholodnov in Telegram and Instagram");
    Console.WriteLine();
    Console.WriteLine("Please, take a look at my solution of the assigned task below:");
    Console.WriteLine();
}
Introduction();

int CheckWhetherEverythingIsRight(string text) //Checking whether you are attentive while reading instructions
{
    if (text == "")
    {
        Console.WriteLine("");
        Console.WriteLine("Whoops! Seems like you have not typed anything. Please, try again.");
        var i = Console.ReadLine();
        return CheckWhetherEverythingIsRight(i);
    }
    else if (int.TryParse(text, out int i))
    {
        if (i != 0)
        {
            return i;
        }
        else 
        {
            Console.WriteLine("");
            Console.WriteLine("Nope! The program won't work without relevant data. Please, type a number of elements you want to use in the program.");
            var a = Console.ReadLine();
            return CheckWhetherEverythingIsRight(a);
        }
    }
    else 
    {
        Console.WriteLine("");
        Console.WriteLine("Whoopsie! You have entered invalid characters. Please, I beg you, type a number of elements.");
        var a = Console.ReadLine();
        return CheckWhetherEverythingIsRight(a);
    }
}

Console.Write("Type a number of elements in the array: ");
int i = CheckWhetherEverythingIsRight(Console.ReadLine());


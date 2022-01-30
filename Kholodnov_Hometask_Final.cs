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

Console.Write("Please, type a number of elements to add to the the array: ");
int i = CheckWhetherEverythingIsRight(Console.ReadLine());

string[] array = new string[i];
string temporary = string.Empty;
int count = 0;
int ArrayStarts = 0;
int ArrayLimitations = 4;

Console.WriteLine("");
Console.WriteLine("Please, type anything you want: ");

for (int b = 0; b < i; b++)
{
    Console.Write(b + 1 + ") ");
    temporary = Console.ReadLine();
    if (temporary.Length > ArrayStarts && temporary.Length < ArrayLimitations)
    {
        array[count] = temporary;
        count++;
    }
}

Array.Resize(ref array, count);

if (array.Length > 0)
{
    Console.WriteLine("");
    Console.WriteLine("Congratulations! You've got your new array! Sorry, but limitations of this program do not allow me showing anything with less than 1 and more than 3 characters.");
    Console.WriteLine("");
    for ( int b = 0; b < array.Length; b++)
    {
        Console.WriteLine(b + 1 + ") " + array[b]);
    }
}
else
{
    Console.WriteLine("");
    Console.WriteLine("You've reached program limitations. I cannot show anything with less than 1 and more than 3 characters. Please, try running the program again.");
    Console.WriteLine("");
}

Console.WriteLine("");
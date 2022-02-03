// See https://aka.ms/new-console-template for more information
Console.Write("Enter a number: ");
int mynumb = int.Parse(Console.ReadLine());
for (int i = mynumb; i >= 0; i--)
{
    Console.Write(i + " ");

    if (i == 0)
    {
        Console.WriteLine(); // Goto next line.
        Console.Write("Would you like to continue (y/n)? ");
        char continueNumb = char.Parse(Console.ReadLine());
        if (continueNumb == 'y')
        {

            Console.Write("Enter a number: ");
            int mynumbNext = int.Parse(Console.ReadLine());
            i = mynumbNext + 1; // Need to add 1 for the first decrement.
        }
    }
}
Console.WriteLine("Goodbye!");


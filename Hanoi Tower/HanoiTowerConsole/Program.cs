// See https://aka.ms/new-console-template for more information



var numDiscs = GetNumberOfDiscsFromUser();



static int GetNumberOfDiscsFromUser()
{
    Console.WriteLine("Please, enter the number of discs (greater than 2): ");
    var input = Console.ReadLine();

    if (!int.TryParse(input, out var discs))
    {
        throw new Exception("Input invalid! Try again");
    }

    return discs;
}

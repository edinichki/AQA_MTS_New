// See https://aka.ms/new-console-template for more information

using Event;

class Program
{
    public delegate void Handler(string alpha, string beta);   //создали делегат

    //public static event Handler OnStuck;                     //чтобы объявить наше событие
    public static Handler OnStuck;

    static void Main()
    {
        //OnStuck += ShowMessage;
        //OnStuck("Alex", "Trostyanko");

        ClientDelegateProgram clientDelegateProgram = new ClientDelegateProgram();
        clientDelegateProgram.Run();

        ClientEventProgram clientEventProgram = new ClientEventProgram();
        clientEventProgram.Run();
    }

    private static void ShowMessage(string firstname, string lastname)
    {
        Console.WriteLine($"{firstname} {lastname} Have fun!!!");
    }
}

namespace methodoverloads;

class Program
{
    static void Main(string[] args)
    {
        var message = new WelcomeMessage();
        message.Print();
        var message1 = new WelcomeMessage("Heisann", "Per!");
        message1.Print();

    }
}
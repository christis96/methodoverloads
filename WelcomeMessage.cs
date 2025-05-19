namespace methodoverloads;

public class WelcomeMessage
{
    public string Firstmessage { get; set; }
    public string Secondmessage { get; set; }

    public WelcomeMessage(string FirstMessage = "Heisann, mr. Anon!")
    {
        Firstmessage = Firstmessage;
    }

    public WelcomeMessage(string FirstMessage="Heisann, mr. Anon!", string SecondMessage = "Velkommen!")
    {
        Firstmessage = FirstMessage;
        Secondmessage = SecondMessage;
    }

    public void Print()
    {
        Console.WriteLine(Firstmessage+""+Secondmessage);
    }
}
namespace methodoverloads;

public class WelcomeMessage
{
    public string Firstmessage { get; set; }
    public string Secondmessage { get; set; }
    
    public string Compliment { get; set; }

    public WelcomeMessage(string FirstMessage)
    {
        Firstmessage = Firstmessage;
    }

    public WelcomeMessage(string FirstMessage="Heisann, mr. Anon!", string SecondMessage = "Velkommen!")
    {
        Firstmessage = FirstMessage;
        Secondmessage = SecondMessage;
    }

    public void Print(string Compliment = "Du er snill!")
    {
        Console.WriteLine(Firstmessage + " " + Secondmessage + " " + Compliment);
    }
}
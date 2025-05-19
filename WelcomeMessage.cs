namespace methodoverloads;

public class WelcomeMessage
{
    public string FirstMessage { get; set; }
    public string SecondMessage { get; set; }
    
    public string Compliment { get; set; }

    public WelcomeMessage(string firstMessage)
    {
        FirstMessage = firstMessage;
    }

    public WelcomeMessage(string firstMessage="Heisann, mr. Anon!", string secondMessage = "Velkommen!")
    {
        FirstMessage = firstMessage;
        SecondMessage = secondMessage;
    }

    public void Print(string Compliment = "Du er snill!")
    {
        Console.WriteLine($"{FirstMessage} {SecondMessage} {Compliment}");
    }
}
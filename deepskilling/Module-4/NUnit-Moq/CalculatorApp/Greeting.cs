namespace CalculatorApp;

public class Greeting
{
    private readonly IMessageService messageService;

    public Greeting(IMessageService messageService)
    {
        this.messageService = messageService;
    }

    public string Welcome()
    {
        return messageService.GetMessage();
    }
}
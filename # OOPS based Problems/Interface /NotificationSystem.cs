/*
Create an interface INotifier with method Send(string message).
Implement it in: EmailNotifier , SMSNotifier ,PushNotifier

Then write a service that accepts INotifier and sends a notification.
*/

using System;

public interface INotifier{
	
     void Send(string message);
    
}

public class EmailNotifier:INotifier{
	
    public void Send(string message){
    	Console.WriteLine($"Email Notification : {message}");
    }
}
public class SMSNotifier : INotifier{

	public void Send(string message){
    	Console.WriteLine($"SMS Notification : {message}");
    }
}
public class PushNotifier : INotifier{

	public void Send(string message){
    	Console.WriteLine($"Push Notification : {message}");
    }
}
public class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void SendNotification(string message)
    {
        _notifier.Send(message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var emailService = new NotificationService(new EmailNotifier());
        emailService.SendNotification("Hello via Email!");
        
        var smsService = new NotificationService(new SMSNotifier());
        smsService.SendNotification("Hello via SMS!");
        
        var pushService = new NotificationService(new PushNotifier());
        pushService.SendNotification("Hello via Push Notification!");
    }
}

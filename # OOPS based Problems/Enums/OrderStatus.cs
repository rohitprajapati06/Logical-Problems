using System;

public enum OrderStatus
{
    Pending,
    Processing,
    Shipped,
    Delivered,
    Cancelled
}

public class OrderStatusPrinter
{
    public static void PrintMessage(OrderStatus status)
    {
        switch (status)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Your order is pending and will be processed soon.");
                break;
            case OrderStatus.Processing:
                Console.WriteLine("We're currently processing your order.");
                break;
            case OrderStatus.Shipped:
                Console.WriteLine("Your order has been shipped and is on its way!");
                break;
            case OrderStatus.Delivered:
                Console.WriteLine("Your order has been successfully delivered.");
                break;
            case OrderStatus.Cancelled:
                Console.WriteLine("Your order has been cancelled.");
                break;
            default:
                Console.WriteLine("Unknown order status.");
                break;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Order Status Messages:");
        Console.WriteLine("----------------------");
        
        OrderStatusPrinter.PrintMessage(OrderStatus.Pending);
        OrderStatusPrinter.PrintMessage(OrderStatus.Processing);
        OrderStatusPrinter.PrintMessage(OrderStatus.Shipped);
        OrderStatusPrinter.PrintMessage(OrderStatus.Delivered);
        OrderStatusPrinter.PrintMessage(OrderStatus.Cancelled);
        
        Console.WriteLine("\nTracking an order's progression:");
        Console.WriteLine("--------------------------------");
        
        OrderStatus currentStatus = OrderStatus.Pending;
        OrderStatusPrinter.PrintMessage(currentStatus);
        
        currentStatus = OrderStatus.Processing;
        OrderStatusPrinter.PrintMessage(currentStatus);
        
        currentStatus = OrderStatus.Shipped;
        OrderStatusPrinter.PrintMessage(currentStatus);
        
        currentStatus = OrderStatus.Delivered;
        OrderStatusPrinter.PrintMessage(currentStatus);
    }
}

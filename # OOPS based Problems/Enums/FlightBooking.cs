using System;

public enum ClassType{
	Economy,
    Buisness,
    FirstClass
}
public class BookTicket{
	
    public string Name {get;set;}
    public double Price{get;set;}
    public ClassType Class{get;set;}
        
    public void ShowInformation(){
    	Console.WriteLine($" Name : {Name}\n Type : {Class}\n Price : {Price}");
    }
}
public class Program{
	public static void Main(string[] args){
    	BookTicket ticket = new BookTicket{
			Name = "Rohit Prajapati",
			Price = 50000.98,
			Class = ClassType.Buisness
		};
        ticket.ShowInformation();
    }
}

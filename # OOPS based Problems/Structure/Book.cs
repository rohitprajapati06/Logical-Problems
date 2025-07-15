using System;

public struct Book{
	public string Author {get;set;}
    public string Title {get;set;}
    public int Year {get;set;}
    
    public Book(string author,string title,int year){
    	 Author = author;
         Title = title;
         Year = year;
    }
    public void Display(){
    	Console.WriteLine($"Author : {Author} \n Title : {Title}\n Year : {Year}");
    }
} 
public class Program{
	public static void Main(){
    	Book bk = new Book("joe","dark",1993);  
        bk.Display();
    }
}

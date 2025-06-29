/*
Problem:  Create a base class LibraryItem with properties Title, Author, PublicationYear. Create derived classes Book, Magazine, DVD. 
Add extra properties (e.g., PageCount for Book, Duration for DVD), and override a method DisplayInfo().
*/

using System;

public abstract class LibraryItem{
	 
	 public string Title{ get;set;}
	 public string Author {get; set;}
	 public int PublicationYear {get;set;}
	 
	 public LibraryItem(string title,string author,int year){
	 	 Title = title;
		 Author = author;
		 PublicationYear = year;
	 }
	 public abstract void DisplayInfo();
}
public class Book : LibraryItem{
	  
	 public int PageCount {get;set;}
	 
	 public Book(int page , string title , string author , int year):base(title,author,year){
	 			PageCount = page;
	 }
	 
	 public override void DisplayInfo(){
	 	  Console.WriteLine($"\n Book\n Author : {Author}\n Title : {Title}\n Published : {PublicationYear}\n Total Pages : {PageCount}");
	 }
}
public class DVD : LibraryItem{
	 	
	 public int Duration {get;set;}
	 
	 public DVD(int duration,string title,string author,int year):base(title,author,year){
	 		Duration = duration;
	 }
	 public override void DisplayInfo(){
	 	  Console.WriteLine($"\n DVD\n Author : {Author}\n Title : {Title}\n Published : {PublicationYear}\n Duration : {Duration}min");
	 }
}
public class Magazine : LibraryItem{
	 
	  public int PageCount {get;set;}
	 
	 public Magazine(int page , string title , string author , int year):base(title,author,year){
	 			PageCount = page;
	 }
	 
	 public override void DisplayInfo(){
	 	  Console.WriteLine($"\n Magazine\n Author : {Author}\n Title : {Title}\n Published : {PublicationYear}\n Total Pages : {PageCount}");
	 }
}
class Program{
	  public static void Main(string[] args){
	  		
		   LibraryItem book = new Book(256,"The Kungfu Panda","Joe Kerry",2012);
		   book.DisplayInfo();
		  
		   LibraryItem magazine = new Magazine(348,"Strangers Things","Steve ",2005);
		   magazine.DisplayInfo();
		  
		   LibraryItem dvd = new DVD(120,"Dark","Micheal Kennewhal ",2014);
		   dvd.DisplayInfo();
	  }
}

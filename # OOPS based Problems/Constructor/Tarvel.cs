using System;

public class Place{
	
    public string Country {get;set;}
    public string Destination {get;set;}
    
    public Place(){}
    
    public Place(Place other){
    	this.Country = other.Country;
        this.Destination = other.Destination;
    }
    
    public void ShowDestination(){
    	Console.WriteLine($"Place : {Country} - {Destination}");        
    }
}
public class Program{
	public static void Main(string[] args){
    	   
         Place p1 = new Place();
         p1.Country = "India";
         p1.Destination = "Taj";
         p1.ShowDestination();
         
         Place p2 = new Place(p1);
         p2.ShowDestination();		//Copied Object
         
         p2.Country = "Spain";			//Modified Object
         p2.Destination = "Barcelona";
         p2.ShowDestination();
    }
}

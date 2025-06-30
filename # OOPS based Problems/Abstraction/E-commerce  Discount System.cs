/*
Problem:    Create a base class Discount with method CalculateDiscountedPrice(price). Create SeasonalDiscount, ClearanceDiscount, and MemberDiscount classes 
that inherit from it and apply different discount rules.
*/

using System;

public abstract class Discount{
	
	public abstract void CalculateDiscountedPrice(decimal price);
}

public class SeasonalDiscount : Discount{	
	 
	  public string Season {get;set;}
	
	  public SeasonalDiscount(string season){
	  	    Season = season;
	  }
	  
	  	public override void CalculateDiscountedPrice(decimal price){
			
			decimal DiscountAmount = 0;
			
			 if(Season == "Summer"){
			 	  DiscountAmount = price * 30 / 100;
			 }else if(Season == "Festival"){
			 	   DiscountAmount = price * 40 / 100;
			 }else if(Season == "Winter"){
			 	   DiscountAmount = price * 20 / 100;
			 }else if(Season == "Rainy"){
			 	   DiscountAmount = price * 10 / 100;
			 }else{
			 	 Console.WriteLine($" No Discount Applied \n Price to be paid : {price}");
				 return;
			 }
			 
			 decimal NewPrice = price - DiscountAmount;
			 Console.WriteLine($"\n Original Price :{price}\n After Seasonal Discount Original Price is {NewPrice}");
		}
}

public class ClearanceDiscount:Discount{
		
	 public override void CalculateDiscountedPrice(decimal price){
	 		 
		 decimal DiscountAmount = 0;
		 
		 if(price >= 10000){
			  DiscountAmount = price * 50 / 100;			     
		 }else if(price > 8000){
		 	  DiscountAmount = price * 40 / 100;			     	
		 }else if(price > 6000){
		 	  DiscountAmount = price * 30 / 100;			     	
		 }else{
		 	  DiscountAmount = price * 20 / 100;			     			 	    
		 }
		 
		 decimal NewPrice = price - DiscountAmount;
         Console.WriteLine($"\n Original Price :{price}\n After Clearance Discount Original Price is {NewPrice}");		 
	 }
}
public class MemberDiscount:Discount{
	  
	public string Member{get; set;}
	
	public MemberDiscount(string member){
			Member = member;
	}
	
	 public override void CalculateDiscountedPrice(decimal price){
	 	  
		 decimal DiscountAmount = 0;
		 if(Member == "Premium"){
		 	 if(price > 6000){
			 	DiscountAmount = 3000;
			 }else if(price > 2000){
			 	DiscountAmount = 1000;			 	
			 }else{
			 	DiscountAmount = 500;			 				 	
			 }
		 }else if(Member == "Gold"){
		 	 if(price > 6000){
			 	DiscountAmount = 1500;
			 }else{
			 	DiscountAmount = 1000;			 	
			 }
		 }else{
		 	  DiscountAmount = 100;
		 }
		 
		decimal NewPrice = price - DiscountAmount;
        Console.WriteLine($"\n Original Price :{price}\n After Clearance Discount Original Price is {NewPrice}");	
	 }

}
public class Program{
	public static void Main(){
		  SeasonalDiscount season = new SeasonalDiscount("Festival");
		  season.CalculateDiscountedPrice(5000);
		
		  ClearanceDiscount clearnce = new ClearanceDiscount();
		  clearnce.CalculateDiscountedPrice(8000);
		
		 MemberDiscount member = new MemberDiscount("Premium");
		 member.CalculateDiscountedPrice(10000);
	}
}
	
		  
		

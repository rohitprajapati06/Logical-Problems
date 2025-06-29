/*
Problem :  Create an abstract class Payment with an abstract method MakePayment(). Create derived classes CreditCardPayment, DebitCardPayment, NetBankingPayment that implement the method.
*/
using System;

public abstract class Payment{
	
     public string TransactionId {get;set;}
     public decimal Amount {get; set;}
     
     public Payment(decimal amount ){
     	  	Amount = amount;
            TransactionId = GenerateTransactionId();
     }
     
     public abstract void MakePayment();
     
     public string GenerateTransactionId(){
     	return "IND" + DateTime.Now.Ticks.ToString();
     }
     
     public void DisplayInformation(){
     	Console.WriteLine($" Payment of Rs.{Amount} has been charged from your account ");
        Console.WriteLine($" Transaction Id : {TransactionId}");
     }
}
public class CreditCardPayment : Payment {
		
	 public long CardNumber {get; set;}
	 public string ExpiryDate {get; set;}
	 public int Cvv {get;set;}
	
	 public CreditCardPayment(long cardno , string expdate , int cvv , int amount ):base(amount){
	 		CardNumber = cardno;
		    ExpiryDate = expdate;
		 	Cvv = cvv;
	 }
	 
	 public override void MakePayment(){
	 	 Console.WriteLine($"Processing The Paymnet via Credit Card");
		 Console.WriteLine($" Amount : {Amount} \n CreditCard Number : {CardNumber}\n ExpiryDate : {ExpiryDate}\n CVV : {Cvv}\n");
		 DisplayInformation();
	 }
}

public class DebitCardPayment : Payment{
	
	public long CardNumber {get ;set;}
	public int Pin {get ; set;}
	
	public DebitCardPayment(long cardno , int pin , int amount):base(amount){
			CardNumber = cardno;
		    Pin = pin;
	}
	
	public override void MakePayment(){
		  Console.WriteLine("\n\n\nProcessing the Payment via Debit Card");
		  Console.WriteLine($" Amount : {Amount}\n DebitCard Number : {CardNumber}\n ");
		  DisplayInformation();
	}
}
public class NetBanking : Payment{
	
	public string BankName {get; set;}
	public int userId {get; set;}
	
	public NetBanking(string bankname , int userid , int amount):base(amount){
			BankName = bankname;
		    userId = userid;
	}
	
	public override void MakePayment(){
		Console.WriteLine("\n\n\nProcessing the Payment via Netbanking");
		Console.WriteLine($" Amount : {Amount}\n Bank Name : {BankName}\n User Id : {userId}\n");
		DisplayInformation();
	}
}
public class Program{
	public static void Main(){
		
		Payment card1 = new CreditCardPayment(885044608915 , "07/29",567,5000);
		card1.MakePayment();
		
		Payment card2 = new DebitCardPayment(869382676058, 456152 , 4000);
		card2.MakePayment();
		
		Payment netbanking = new NetBanking("HDFC",5426,8000);
		netbanking.MakePayment();
	}
}

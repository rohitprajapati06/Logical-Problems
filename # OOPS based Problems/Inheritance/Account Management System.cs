/*                                                                      Account Management System
Problem:   Create a base class BankAccount with properties AccountNumber, Balance, and method Deposit() and Withdraw(). 
Create derived classes SavingsAccount and CheckingAccount that implement withdrawal limits and minimum balance rules.
*/

using System;
					
class BankAccount{
	
	public long AccountNumber{get;set;}
	public long Balance {get;set;}
	
	public BankAccount(long acc_no , long balance){
		AccountNumber = acc_no;
		Balance = balance;
	}
	
	public virtual void Withdraw(long Amount){
		Console.WriteLine("Withdraw Successfully");	
	}
	public virtual void Deposit(long Amount){
		Console.WriteLine("Deposit Successfully");	
	}
}
class SavingAccount : BankAccount {
	
	 public long WithdrawlLimits {get ; set;}
	 public long MinimumBalance {get; set;}
	
	 public SavingAccount(long withdrawlimit , long minbalance , long acc_no , long balance) : base(acc_no,balance){
	 		WithdrawlLimits = withdrawlimit;
		    MinimumBalance =  minbalance;
	 }
	
	 public override void Withdraw(long Amount){
		 if (Amount <= 0){
            Console.WriteLine("Withdrawal amount must be positive");
            return;
       		}
        Console.WriteLine("\nProcessing saving account withdrawal...");
			
		 
		    if(Amount > Balance){
				Console.WriteLine("Insufficient Balance");
			}
	 	  	else if(Amount > WithdrawlLimits){
				 Console.WriteLine($"Account has an Withdraw Limit of Rs.{WithdrawlLimits} \n Please choose an amount below the Withdraw Limit");
			}
		 	else{
				Console.WriteLine($"Withdrawl Successfully");
				Console.WriteLine($"Balance : {Balance - Amount}");
				if(MinimumBalance > Balance){
					Console.WriteLine($"Your Minimum Balance Should be {MinimumBalance}");
				}
			}
	 }
	
	 public override void Deposit(long Amount){
		 if (Amount <= 0){
            Console.WriteLine("Withdrawal amount must be positive");
            return;
       		}
         Console.WriteLine("\nProcessing saving account deposit...");

	 	    Console.WriteLine($"Balance : {Amount + Balance}");
		 	if(MinimumBalance > Balance){
					Console.WriteLine($"Your Minimum Balance Should be {MinimumBalance}");
				}
	 }
}

class CheckingAccount : BankAccount{
	 
	 public long WithdrawlLimits {get ; set;}
	 public long MinimumBalance {get; set;}
	
	  public CheckingAccount(long withdrawlimit , long minbalance , long acc_no , long balance ) : base(acc_no,balance){
	 		WithdrawlLimits = withdrawlimit;
		    MinimumBalance =  minbalance;
	 }
	  
	 public override void Withdraw(long Amount){
		 if (Amount <= 0){
            Console.WriteLine("Withdrawal amount must be positive");
            return;
       		}
        Console.WriteLine("\nProcessing checking account withdrawal...");
		    if(Amount > Balance){
				Console.WriteLine("Insufficient Balance");
			}
	 	  	else if(Amount > WithdrawlLimits){
				 Console.WriteLine($"Account has an Withdraw Limit of Rs.{WithdrawlLimits} \n Please choose an amount below the Withdraw Limit");
			}
		 	else{
				Console.WriteLine($"Withdrawl Successfully");
				Console.WriteLine($"Balance : {Balance - Amount}");
				if(MinimumBalance > Balance){
					Console.WriteLine($"Your Minimum Balance Should be {MinimumBalance}");
				}
			}
	 }
	
	 public override void Deposit(long Amount){
		 if (Amount <= 0){
            Console.WriteLine("Withdrawal amount must be positive");
            return;
       		}
        Console.WriteLine("\nProcessing checking account deposit...");

	 	    Console.WriteLine($"Balance : {Amount + Balance}");
		 	if(MinimumBalance > Balance){
					Console.WriteLine($"Your Minimum Balance Should be {MinimumBalance}");
				}
	 }
}

class Program{
	public static void Main(){
		
		BankAccount savings = new SavingAccount(10000, 1000 ,1255054126, 5000);
        savings.Deposit(2000);
        savings.Withdraw(12000); 
        savings.Withdraw(9000);  
        savings.Withdraw(500);   
        
        Console.WriteLine();
        
        BankAccount checking = new CheckingAccount(40000,3000,1254620126, 10000);
        checking.Withdraw(8000);
        checking.Deposit(3000);
        checking.Withdraw(10000); 
        checking.Withdraw(1000);  
	}
}

/*
                                                                                        Employee Hierarchy
Problem:  Create a base class Employee with properties Name, Id, and method CalculateSalary(). Create two subclasses: FullTimeEmployee and PartTimeEmployee. 
Override the CalculateSalary() method in both based on hours or fixed salary.
*/

using System;

class Employee{
	
    public string Name {get ; set;}
    public int Id {get; set;}
    
    public Employee(string name , int id){
    		Name = name;
        	Id = id;
    }
    
    public virtual void CalculateSalary(){
    	Console.WriteLine($"Calculating an Salary of Employee {Id}-{Name} Based on Hours and Fixed Pay");
    }
}

class FullTimeEmployee : Employee{
	 
      public int hours {get; set;}
      public int hourlyrate {get; set;}
      
      
      public FullTimeEmployee(int Hours , int Hourlyrate , string Name , int Id): base(Name , Id){
      	 	hours = Hours;
          hourlyrate = Hourlyrate;            
      }
      
      public override void CalculateSalary(){
      		Console.WriteLine($"\n {Id} - {Name} Salary is  Rs.{hours * hourlyrate}");
      }
}

class PartTimeEmployee : Employee{
	
    public int hours {get ; set;}
    public int hourlyrate {get ; set ;}
    
    public PartTimeEmployee(int Hours , int Hourlyrate , string Name , int Id): base(Name , Id){
    	 	hours = Hours;
        hourlyrate = Hourlyrate;
    }
    
    public override void CalculateSalary(){
    	Console.WriteLine($"\n {Id} - {Name} Salary is  Rs.{hours * hourlyrate}");
    }
}
public class Program{
	public static void Main(string[] args){
    	        
         Employee obj2 = new FullTimeEmployee(10,400,"Rohit",5);
         obj2.CalculateSalary();
         
         Employee obj3 = new PartTimeEmployee(6,400,"Aman",3);
         obj3.CalculateSalary();

    }
}

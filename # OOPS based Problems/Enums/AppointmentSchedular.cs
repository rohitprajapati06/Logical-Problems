using System;

public enum Department{
	Cardiology,
    Neurology,
    Orthopedic
}
public class Appointment{
	
    public string PatientName {get;set;}
    public DateTime Date {get;set;}
    public Department Department {get;set;}
    
    public Appointment(string name , DateTime date, Department dept){
    	PatientName = name;
        Date = date;
        Department = dept;
    }
    
    public void PrintDetails(){
    	Console.WriteLine($"\n Patient : {PatientName}\n Date : {Date} \n OPD : {Department}");
    }
}
public class Program{
	public static void Main(string[] args){
    	Appointment pat = new Appointment("Rohit Prajapati",DateTime.Parse("2025-04-04 12:15:00"),Department.Neurology);
        pat.PrintDetails();
		
		Appointment pat2 = new Appointment("Rahul Mishra",DateTime.Parse("2025-08-04 14:30:00"),Department.Orthopedic);
        pat2.PrintDetails();
    }
}

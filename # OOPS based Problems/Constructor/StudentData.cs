using System;

class Student{
	
    public string Name{get;set;}
    public int No {get;set;}
    
    public Student(){
    	Name ="Unknown";
        No = 0;
    }
    
    public Student(string name,int no){
    	Name = name;
        No = no;
    }
    
    public void Show(){
    	Console.WriteLine($"Student : {Name}-{No}");
    }
}
public class Program{
	public static void Main(){
   		Student stu = new Student();
        stu.Show();
        
        Student stu1 = new Student("Rohit",10);
        stu1.Show();
   }	
}

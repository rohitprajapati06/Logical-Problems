/*
Problem : Create a Student class and a Course class. Each student can enroll in multiple courses, and each course can be offered to multiple students.
*/

using System;
using System.Collections.Generic;

public class Employee{
	
    public string Name{get;set;}
    public int ID{get;set;}
    public string Role {get;set;}
    
    public Employee(string name , int id , string role){
    	Name = name;
        ID = id; 
        Role = role;
    }
}
public class Department{
	
    public string DepartmentName {get;set;}
    public List<Employee> employee;
    
    public Department(string name){
    	DepartmentName = name;
    	employee = new List<Employee>();
    }
	
	public void AddEmployee(Employee emp) {
        employee.Add(emp);
    } 
}

public class Company{
	
    public string CompanyName{get;set;}
    public List<Department> department;
    
    public Company(string name){
    	CompanyName = name;
        department = new List<Department>();
    }
    
    public void SaveDepartment(Department dept){
        department.Add(dept);
    }
    
    public void ShowDetials(){
    	 foreach(var dept in department){
            Console.WriteLine($"Department: {dept.DepartmentName}");
            foreach(var emp in dept.employee){
                Console.WriteLine($"Employee: {emp.Name}");
                Console.WriteLine($"ID: {emp.ID}");
                Console.WriteLine($"Role: {emp.Role}\n");
            }
            Console.WriteLine();
        }
    }
}
public class Program{
	public static void Main(string[] args){
    	
         Employee emp1 = new Employee("Rohit",101,"Software Engineer");
         Employee emp2 = new Employee("Rahul",102,"CyberSecurity Engineer");
         
         Department dept1 = new Department("IT");
		 dept1.AddEmployee(emp1);

         Department dept2 = new Department("Security");
         dept2.AddEmployee(emp2);
		
         Company company = new Company("Wipro");
		 company.SaveDepartment(dept1);
         company.SaveDepartment(dept2);
		
         company.ShowDetials();
         
         
    }
}

/*
Problem : A Teacher can teach multiple Subjects, and each Subject can be taught by multiple Teachers.
*/

using System;
using System.Collections.Generic;

public class Subject{

    public string SubjectName {get;set;}
    public int Subjectcode {get;set;}
    
    public Subject(string name ,int code){
    	SubjectName = name;
        Subjectcode = code;
    }
}
public class Teacher{
	
    public string TeacherName {get;set;}
    public int Id {get;set;}
    public List<Subject> subject {get;set;}
    
    public Teacher(string name , int id){
    	TeacherName = name;
        Id = id;
        subject = new List<Subject>();
    }
    
    public void AssignSubject(Subject sub){
    	 subject.Add(sub);
    }
    
    public void DisplayAssignedSubject(){
    	 Console.WriteLine($"Teacher : {TeacherName} - {Id}");
         foreach(var sub in subject){
         	 Console.WriteLine($" {sub.SubjectName} - {sub.Subjectcode}");
         }
    }
}
public class Program{
	public static void Main(string[] args){
    	  Subject sub1 = new Subject("Math",1);
    	  Subject sub2 = new Subject("Science",2);
          
          Teacher teacher = new Teacher("Seema",101);
          teacher.AssignSubject(sub1);
          teacher.AssignSubject(sub2);
          
          teacher.DisplayAssignedSubject();
          
    }
}

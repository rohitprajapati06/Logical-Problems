/*
Problem : Create a Student class and a Course class. Each student can enroll in multiple courses, and each course can be offered to multiple students.
*/
using System;
using System.Collections.Generic;

public class Course{
	
    public string CourseName {get;set;}
    public int CourseCode {get;set;}
    
    public Course(string course , int code){
    	CourseName = course;
        CourseCode = code;
    }        
}

public class Student{
	
     public string Name {get;set;}
     public int RollNo {get;set;}
     public List<Course> EnrolledCourses ;
     
     public Student(string name , int rollno){
     	Name = name;
        RollNo = rollno;
        EnrolledCourses = new List<Course>();
     }
     
     public void EnrolledCourse(Course courses){
     	 EnrolledCourses.Add(courses);
         Console.WriteLine($"{Name} has enrolled in {courses.CourseName}.");

     }
     
     public void DisplayAllCourse(){
     	  foreach(var course in EnrolledCourses){
          		 Console.WriteLine($" {course.CourseName} - {course.CourseCode}");
          }
     }
}
public class Program{
	public static void Main(){
    	  
          Course course = new Course("CyberSecurity",586);
          Course course1 = new Course("AI ML",587);
          Course course2 = new Course("Software Testing",588);
          
          Student student1 = new Student("Rahul",203);
          student1.EnrolledCourse(course);
          student1.EnrolledCourse(course2);

          
    }
}

/*
1. Shape Inheritance
Problem:
Create a base class Shape with properties like Color and a method Draw(). 
Derive classes like Circle, Rectangle, and Triangle that override the Draw() method and add their own unique properties (like radius for Circle, width and height for Rectangle).
*/

using System;

class Shape {
	
    public string color {get ; set ;}
    
    public Shape(string Color){
    	 color = Color;
    }
    
    public virtual void Draw(){
    	 Console.WriteLine($"I am drawing an Shape of {color} color");
    }
}

class Circle : Shape{
	
    public float radius {get ; set;}
    
    public Circle(float Radius ,string Color) : base(Color){
    	 radius = Radius;
    }
     
    public override void Draw(){
    	 Console.WriteLine($"\nI am drawing an Circle of radius {radius}cm of an  {color} color");
    }
}

class Rectangle : Shape {
	
    public int Length;
    public int Breadth;
    
    public Rectangle(int length , int breadth ,string Color):base(Color){
    	Length = length;
        Breadth = breadth;
    }
    
    public override void Draw(){
    	Console.WriteLine($"\nI am drawing an Rectangle of {color} color that have Length and Breadth of {Length}cm & {Breadth}cm");
    }
}

class Triangle : Shape{
	
    public int Length;
    public int Breadth;
    public int Hieght;
    
    public Triangle(int length , int breadth , int hieght ,string Color):base(Color){
    	Length = length;
        Breadth = breadth;
        Hieght = hieght;
    }
    
    public override void Draw(){
    	Console.WriteLine($"\nI am Drawing an Triangle of {color} color with an Hiegth {Hieght}cm , Breadth {Breadth}cm and Length {Length}cm");
    }
}

public class Program{
	public static void Main(string[] args){
    	 
         Shape obj1 = new Shape("red");
         obj1.Draw();
         
         Shape obj2 = new Circle(5.4F,"yellow");
         obj2.Draw();
         
         Shape obj3 = new Rectangle(6,5,"green");
         obj3.Draw();
         
         Triangle obj4 = new Triangle(8,6,4,"blue");
         obj4.Draw();
    }
}

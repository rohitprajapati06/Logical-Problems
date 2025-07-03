using System;

public class Engine{
	
    public string Type{get;set;}
    public int HorsePower{get;set;}
    
    public Engine(string type,int hp){
    	Type = type;
        HorsePower = hp;
    }
    
    public void Start(){
    	Console.WriteLine($"Engine Started :{Type} - {HorsePower}");
    }
}
public class Car{
	
    public string Model{get;set;}
    public Engine Engine{get;set;}
    
    public Car(string model,Engine engine){
    	Model = model;
        Engine = engine;
    }
    
    public void StartCar(){
    	Engine.Start();
        Console.WriteLine($"{Model} has been started");
    }    
}
public class Program{
	public static void Main(string[] args){
    	
        Engine engine = new Engine("V8",687);
        Car car = new Car("Mercedes",engine);
        car.StartCar();
    }
}

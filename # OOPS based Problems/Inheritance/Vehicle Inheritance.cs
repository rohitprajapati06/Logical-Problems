//                                                                                     Vehicle Inheritance
// Problem: Create a base class Vehicle with properties Speed, Capacity. Derive classes Car, Bus, Bike, and override a method DisplayDetails() in each. 
//Include unique methods, e.g., OpenTrunk() in Car, RingBell() in Bike.

using System;

class Vehicle{
	
    public int speed {get; set;}
    public int capacity {get; set;}
    public int average {get; set;}
    public string model {get; set;}
    public string type {get; set;}
    
    public Vehicle(int Speed , int Capacity , int avg , string Model , string Type){
    	 speed = Speed;
         capacity = Capacity;
         average = avg;
         model = Model;
         type = Type;
         
    }
    
    public virtual void DisplayDetail(){
        Console.WriteLine($" Model : {model} ");
        Console.WriteLine($" Type : {type} ");
    	Console.WriteLine($" Speed : {speed} km/hr");
        Console.WriteLine($" Capacity : {capacity} passengers");
        Console.WriteLine($" average : {average} ");

    }
    
    public virtual void StartEngine()
    {
        Console.WriteLine("Starting vehicle engine");
    }
    
}

class Bus : Vehicle{
	 
       public bool isDoubleDecker {get; set;}
       
      public Bus(bool doubleDecker, int Speed, int Capacity, int avg, string Model, string Type) 
          : base(Speed, Capacity, avg, Model, Type)  
      {
          isDoubleDecker = doubleDecker;
      }
	   
       public override void DisplayDetail(){
        base.DisplayDetail();
		Console.WriteLine($" Has DobleDecker : {isDoubleDecker} ");

       }
       public override void StartEngine(){
       		Console.WriteLine("Engine Started");
       }
      
}
class Car : Vehicle{
	      
     public bool hasSunRoof {get; set;}
     
     public Car(bool HasSunRoof,int Speed , int Capacity , int avg , string Model , string Type):base (Speed, Capacity, avg, Model, Type){
       			hasSunRoof = HasSunRoof;
       }

     public void OpenTrunk(){
     	Console.WriteLine("Trunk Opened");
     }
     
     public override void DisplayDetail(){
        base.DisplayDetail();
		Console.WriteLine($" Has SunRoof : {hasSunRoof} ");

       }
       
       public override void StartEngine(){
       		Console.WriteLine("Engine Started");
       }
}

class Bike : Vehicle{
	   
       public string Horn {get; set;}
       
       public Bike(string ringbell,int Speed , int Capacity , int avg , string Model , string Type):base (Speed, Capacity, avg, Model, Type){
       		Horn = ringbell;
       }
       
       
       public void RingBell(){
       		Console.WriteLine("Ringbell : {Horn}");
       }
       
	   public override void StartEngine(){
       		Console.WriteLine("Bike doesn't have engines");
       }
     
        public override void DisplayDetail(){
                base.DisplayDetail();
       }
     
     
}
class Program{
	static void Main(){
        
        Vehicle obj = new Bus(true,100,60,55,"Ashok LeyLand","Bus");
        obj.DisplayDetail();
        obj.StartEngine();
        
        Vehicle obj1 = new Car(true,200,4,45,"TATA Suv","Car");
        obj1.DisplayDetail();
        obj1.OpenTrunk();
        obj1.StartEngine();
        
        Vehicle obj2 = new Car("Ring Ring",250,2,75,"Hero Honda","Bike");
        obj2.DisplayDetail();
        obj2.RingBell();
        obj2.StartEngine();
        
    }
}

using System;

public class AppConfig{
	
    public static string Version {get;set;}
    
    static AppConfig(){
    	Version = "1.0.0";
    }
    
    public static void PrintConfig()
    {
        Console.WriteLine($"App Version: {Version}");
    }
        
}
public class Program{
	public static void Main(){
    	AppConfig.PrintConfig();
    }
}

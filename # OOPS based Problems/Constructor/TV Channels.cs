using System;

public class TV{
	
    public string Channel{get;set;}
    public int No {get;set;}
    
    public TV(string channel,int no){
    	Channel = channel;
        No = no;
    }
    
    public void ShowChannels(){
    	Console.WriteLine($"Channel : {No}-{Channel}");
    }
}
public class Program{
	public static void Main(){
    	TV channel1 = new TV("Sony",406);
        channel1.ShowChannels();
        
        TV channel2 = new TV("Sony Max",407);
        channel2.ShowChannels();

        TV channel3 = new TV("Sony Sab",408);
        channel3.ShowChannels();

    }
}

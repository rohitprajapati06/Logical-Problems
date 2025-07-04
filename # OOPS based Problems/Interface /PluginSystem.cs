/*
Design an interface IPlugin with method Execute().Create multiple plugin classes like: ImageResizerPlugin , WatermarkPlugin ,CompressorPlugin
Create a PluginManager that accepts a list of IPlugin and executes them all.
*/

using System;

public interface IPlugin{
	
    void Execute();
}

public class ImageResizer : IPlugin{
	
    public void Execute(){
		Console.WriteLine($"Image has been resize");    	
    }
}
public class WatermarkPlugin : IPlugin{
	
    public void Execute(){
		Console.WriteLine($"Watermark has been removed");    	
    }
}
public class CompressorPlugin : IPlugin{
	
    public void Execute(){
		Console.WriteLine($"Image has been Compressed");    	
    }
}
public class PluginManager{
	
    private readonly IPlugin manager;
    
    public PluginManager(IPlugin _manager){
    	manager = _manager;
    }
    
    public void ExecuteAll(){
    	manager.Execute();
    }
}
public class Program{
	public static void Main(){
    	PluginManager resize = new PluginManager(new ImageResizer());
        resize.ExecuteAll();
		
		PluginManager watermark = new PluginManager(new WatermarkPlugin());
        watermark.ExecuteAll();
		
		PluginManager compress = new PluginManager(new CompressorPlugin());
        compress.ExecuteAll();
    }
}

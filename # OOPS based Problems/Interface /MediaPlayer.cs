/*
  Problem : Objective: Design a media player that can play different formats.
*/
using System;

public interface IMediaPlayer{
	
    void Play(string filename);
}
public class MP3Player:IMediaPlayer{
	
    public void Play(string filename){
    	Console.WriteLine($"Play only audio of {filename}");
    }
}
public class MP4Player : IMediaPlayer{
	
    public void Play(string filename){
    	Console.WriteLine($"Play video and audio of {filename}");
    }
}
public class VLCPlayer:IMediaPlayer{
	
    public void Play(string filename){
    	Console.WriteLine($"Play high quality video and audio of {filename}");
    }
}
public class PlayerService{
	
    private readonly IMediaPlayer mediaplayer;
    
    public PlayerService(IMediaPlayer _mediaplayer){
    
    	mediaplayer = _mediaplayer;
    }
    
    public void PlayAll(string filename){
    	 mediaplayer.Play(filename) ;
    }
}
public class Program{
	
    public static void Main(){
    	  
        PlayerService play = new PlayerService(new VLCPlayer());
        play.PlayAll("Shutter Island");
		
		PlayerService play1 = new PlayerService(new MP4Player());
        play1.PlayAll("Inception");
		
		PlayerService play2 = new PlayerService(new MP3Player());
        play2.PlayAll("Interstellar");
    }
}

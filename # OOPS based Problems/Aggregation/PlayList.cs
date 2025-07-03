/*
Problem : Design a Playlist class that contains multiple Song objects. Songs can exist outside a playlist and can belong to multiple playlists.
*/

using System;
using System.Collections.Generic;

public class Song{
	
    public string Title{get;set;}
    public string Artist{get;set;}
    public double Duration{get;set;}
    
    public Song(string title,string artist,double duration){
    		Title = title;
            Artist = artist;
            Duration = duration;
    } 
}
public class PlayList{
	
    public string PlayListName{get;set;}
    public List<Song> Song;
    
    public PlayList(string name){
    	PlayListName = name;
        Song = new List<Song>();
    }
    
    public void AddSong(Song songs){
    	Song.Add(songs);
    }
    
    public void DisplayPlayList(){
    	Console.WriteLine($"\nPlayList : {PlayListName}");
        foreach(var song in Song){
    		Console.WriteLine($" {song.Title} - {song.Artist} {song.Duration}min");        	
        }
        
    }
}
public class Program{
	public static void Main(string[] args){
    	
        Song song1 = new Song("Mockingbird","Eminem",2.12);
        Song song2 = new Song("End of the Beginning","Joe Kerry",1.58);
        Song song3 = new Song("7 Years","Lukas Graham",2.30);
        Song song4 = new Song("Shape of You","Ed Sheeran",3.54);
        Song song5 = new Song("Co2","Prateek Kuhad",2.44);
        
        PlayList playlist1 = new PlayList("Walk");
        playlist1.AddSong(song2);
        playlist1.AddSong(song3);
        playlist1.AddSong(song5);
        playlist1.DisplayPlayList();
        
        PlayList playlist2 = new PlayList("Think");
        playlist2.AddSong(song1);
        playlist2.AddSong(song4);
        playlist2.DisplayPlayList();


    }
}

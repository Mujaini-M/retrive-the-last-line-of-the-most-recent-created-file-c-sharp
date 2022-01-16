using System;

public class Program
{
	public static void Main(string[] args)
	{
		// string[] lines = System.IO.File.ReadAllLines(@"C:\users\Majid\file.txt");
        // for(int i=0;i<3;++i){
        //     Console.WriteLine(lines[i]);
        // }
        
//=====================================================================================================

        var directory = new DirectoryInfo("MyDirectory"); //open folder
        var myFile = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).First(); //fetch info of last modified file
        string path = myFile.FullName; //stor the absolute path of the fetched file
        var lastLine = File.ReadLines(@path).Last(); //read the last line of the file
        Console.WriteLine(lastLine);

//======================================================================================================

        // string[] lines = System.IO.File.ReadAllLines(@path);
        // for(int i=0;i<3;++i){
        //     Console.WriteLine(lines[i]);
        // }
        //Console.WriteLine(myFile);
       
	}
}
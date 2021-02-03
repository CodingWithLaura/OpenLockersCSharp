using System;

namespace OpenLockers
{

public class Program
{
     public static bool[] TheDoorProblem(bool[] doors)
     {
	 bool[] out_doors = new bool[100];

	 //kopiere doors in out_doors
	 for( int i  = 0;i<100;i++)
         {
	     out_doors[i] = doors[i];
	 }
	 
         for(int schrittweite = 1; schrittweite<100; schrittweite++)
         {
             for(int i=0; i<100; i=i+schrittweite)
             {
	         if(out_doors[i])
		 {
		     out_doors[i] = false;
		 }
		 else
		 {
		     out_doors[i] = true;
		 }
	     }
         } 
 	 return out_doors;
    }

    public static int CountTheDoors(bool[] doors)
    {
        int doorCounter = 0;
	foreach (var door in doors)
	{
            if(door == true)
            {
	        doorCounter++;
	    }
	}    
	return doorCounter; 
    }

    public static void DoorOutput(bool[] doors)
    {
	for(int i = 0 ;i<100;i++)
	{
	    if(doors[i] == false)
	    {
	        Console.WriteLine("{0:D} zu", i);
	    }
	    else
	    {
	        Console.WriteLine("{0:D} auf",i);
	    }
	}
    }
    static void Main(string[] args)   
    {				       
    	 bool[] doors = new bool[100]; 
    	 for(int i=0; i<100; i++)      
    	 {			       
    	     doors[i]=false;	       
    	 }			       
	 DoorOutput(doors);		       
    	 bool[] doors2 = TheDoorProblem(doors);
	 DoorOutput(doors2);
	 int anzahl = CountTheDoors(doors2);
	 Console.WriteLine(anzahl);
    }
}
} // Namespace

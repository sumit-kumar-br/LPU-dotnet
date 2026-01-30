using System;
class HMV{
  //your code goes here
  private readonly int  _numberOfWheels;
    public string DriveHMV()
    {
       return _numberOfWheels+""+"wheeler driving";
    }
      public HMV(int numberOfWheels)
    {
          
      _numberOfWheels = numberOfWheels;
      
    }
}
class TwoWheeler{
  //your code goes here

  public string DriveTwoWheeler()
  {

    return "2 wheeler driving";

  }
}
class Driving
{
  //your code goes here

  public string Drive()
  {
        return "2 wheeler driving";
  }
  public string Drive(int numberOfWheels)
  {
          return $"{numberOfWheels} wheeler driving";
  }
  
}
class Source
{
		static void Main(string[] args) 
        {
			    /* Enter your code here. Read input from STDIN. Print output to STDOUT */

          var driving = new Driving();
          var drive = driving.Drive();
          Console.WriteLine($"{drive}");
      
          var drive1 = driving.Drive(8);
          Console.WriteLine($"{drive1}"); 

		}
}

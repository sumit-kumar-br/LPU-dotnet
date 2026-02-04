using System;

public class Vehicle
{
    //your code goes here
    protected int numOfWheels;
    public Vehicle(int noOfWheels) {
        this.numOfWheels = noOfWheels;
    }
    public virtual string Drive() {
        return numOfWheels + " wheeler driving";
    }
}

class TwoWheeler : Vehicle
{
   //your code goes here
   public TwoWheeler():base(2) {}
}

class HMV : Vehicle
{
    //your code goes here
    public HMV(int noOfWheels):base(noOfWheels) {}
}

class Source
{
    static void Main(string[] args)
    {
       //your code goes here
       Vehicle v1 = new TwoWheeler();
       Vehicle v2 = new HMV(8);
       Console.WriteLine(v1.Drive());
       Console.WriteLine(v2.Drive());
    }
}

using System;

namespace BejoyComputers;

public class Laptop: Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }
    public double LaptopPriceCalculation()
    {
        double totalCost=0.0;
        if(Processor == "i3")
        {
            totalCost = 2500 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (BatteryVolt*20) + (DisplaySize*250);
        }
        else if(Processor == "i5"){
            totalCost = 5000 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (BatteryVolt*20) + (DisplaySize*250);
        }
        else if(Processor == "i7")
        {
            totalCost = 6500 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (BatteryVolt*20) + (DisplaySize*250);
        }
        return totalCost;
    }
}

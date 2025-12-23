using System;

namespace BejoyComputers;

public class Desktop: Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        double totalCost=0.0;
        if(Processor == "i3")
        {
            totalCost = 1500 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (PowerSupplyVolt*20) + (MonitorSize*250);
        }
        else if(Processor == "i5"){
            totalCost = 3000 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (PowerSupplyVolt*20) + (MonitorSize*250);
        }
        else if(Processor == "i7")
        {
            totalCost = 4500 + (RamSize*200) + (HardDiskSize*1500) + (GraphicCard*2500) + 
                (PowerSupplyVolt*20) + (MonitorSize*250);
        }
        return totalCost;
    }
}

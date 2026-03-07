using System;

namespace BejoyComputers;

public class Laptop: Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }
    public int DisplayPrice { get; } = 250;
    public int BatteryVoltPrice { get; } = 20;
    public double LaptopPriceCalculation()
    {
        switch (Processor)
        {
            case "i3":
                {
                    ProcessorCost = 1500;
                    break;
                }
            case "i5":
                {
                    ProcessorCost = 3000;
                    break;
                }
            case "i7":
                {
                    ProcessorCost = 4500;
                    break;
                }
            default:
                {
                    break;
                }

        }
        double desktopCost=0.0;
        if(Processor == "i3")
        {
            desktopCost = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
            (GraphicCard * GraphicCardPrice) + (DisplaySize * DisplayPrice) + 
            (BatteryVolt * BatteryVoltPrice);
        }
        else if(Processor == "i5"){
            desktopCost = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
            (GraphicCard * GraphicCardPrice) + (DisplaySize * DisplayPrice) + 
            (BatteryVolt * BatteryVoltPrice);
        }
        else if(Processor == "i7")
        {
            desktopCost = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
            (GraphicCard * GraphicCardPrice) + (DisplaySize * DisplayPrice) + 
            (BatteryVolt * BatteryVoltPrice);
        }
        return desktopCost;
    }
}

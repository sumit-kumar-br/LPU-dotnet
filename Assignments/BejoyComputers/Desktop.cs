using System;

namespace BejoyComputers;

public class Desktop: Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }
    public int MonitorPrice { get; } =250;
    public int PowerSupplyVoltPrice { get; } =20;

    public double DesktopPriceCalculation()
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
            (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + 
            (PowerSupplyVolt * PowerSupplyVoltPrice);
        }
        else if(Processor == "i5"){
            desktopCost = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
            (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + 
            (PowerSupplyVolt * PowerSupplyVoltPrice);
        }
        else if(Processor == "i7")
        {
            desktopCost = ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) + 
            (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) + 
            (PowerSupplyVolt * PowerSupplyVoltPrice);
        }
        return desktopCost;
    }
}

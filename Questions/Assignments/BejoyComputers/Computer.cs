using System;

namespace BejoyComputers;

public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
    public int ProcessorCost { get; set; }
    public int RamPrice { get; }=200; // readonly 
    public int HardDiskPrice { get; }=1500;
    public int GraphicCardPrice { get; }=2500;
}

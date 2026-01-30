using System;
using System.Collections.Generic;
using System.Linq;
using EventDrivenLotteryTicket;



class Program 
{
	static void Main(string[] args) 
    {
        var lottery = new Lottery(new CustomEventArgs{Quantity = 10});
        var winners = lottery.LotteryWinners();
        var index = 1;
        foreach(var winner in winners)
        Console.WriteLine($"{index++}.{winner}");
	}
}


using System;
using System.Collections.Generic;
using System.Linq;


class CustomEventArgs : EventArgs
{
  // your code goes here

  public int Quantity{get;set;}



}


class Lottery
{
  // your code goes here

    private EventHandler<CustomEventArgs> _eventHandler;
    private IList<Guid> _lotteryTickets;

  public Lottery(CustomEventArgs customEventArgs){
        if(customEventArgs.Quantity<10){
          throw new InvalidOperationException();
        }
        
                _eventHandler+=GenerateTickets;
                GenerateTickets(this,customEventArgs);
        

  }
    
    

    public void GenerateTickets(object sender, CustomEventArgs eventArgs){
      _lotteryTickets = new List<Guid>();
      
      for(int i =0;i<eventArgs.Quantity;i++){
        Guid ticket = Guid.NewGuid();
        _lotteryTickets.Add(ticket);
      }
    }


    
    public IList<Guid> LotteryWinners(){

      if(_lotteryTickets == null|| _lotteryTickets.Count ==0){
        throw new InvalidOperationException();
      }
      List<Guid>winners = _lotteryTickets.Distinct().Take(3).ToList();

      return winners;

      

    
  }
}
class Source {
	static void Main(string[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT */
      var lottery = new Lottery(new CustomEventArgs{Quantity =10});
      var winners = lottery.LotteryWinners();
      var index = 1;
      foreach(var winner in winners)
      Console.WriteLine($"{index++}.{winner}");

	}
}

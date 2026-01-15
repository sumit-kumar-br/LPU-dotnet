using System;
namespace SampleAssignment
{
     class PhoneCall
    {
        public delegate void Notify();

        public event Notify PhoneCallEvent;

        public string Message { get; private set; }
       public PhoneCall()
        {
           
        }
        public PhoneCall(string yourMessage)
        {
            Message = yourMessage;
        }
        

         void OnSubscribe()
        {
            Message = "Subscribed to Call";
        }

         void OnUnSubscribe()
        {
            Message = "UnSubscribed to Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            if(notify==true)
            {
                this.OnSubscribe();
            }
            else
            {
                this.OnUnSubscribe();
            }
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            var call=new PhoneCall();
            call.MakeAPhoneCall(true);
            Console.WriteLine($"{call.Message}");
            call.MakeAPhoneCall(false);
            Console.WriteLine($"{call.Message}");
        }
    }
}
using System;
namespace SampleAssignment
{
    public delegate void Notify();

    class PhoneCall
    {
        public event Notify PhoneCallEvent;

        public string Message{ get; private set; }

        public PhoneCall()
        {
           
        }
        public PhoneCall(string yourMessage)
        {
            Message = yourMessage;
        }

        private void OnSubscribe() {
            Message = "Subscribed to Call";
        }

        private void OnUnSubscribe() {
            Message = "UnSubscribed to Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            PhoneCallEvent = null;
            if(notify)
                PhoneCallEvent += OnSubscribe;
            else 
                PhoneCallEvent += OnUnSubscribe;
            PhoneCallEvent?.Invoke();
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
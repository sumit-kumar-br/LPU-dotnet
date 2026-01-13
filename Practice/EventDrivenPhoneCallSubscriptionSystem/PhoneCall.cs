public class PhoneCall
{
    public delegate void Notify();
    public event Notify PhoneCallEvent;
    public string Message { get; private set; }
    private void OnSubscribe()
    {
        Message = "Subscribed to Call";
    }
    private void OnUnSubscribe()
    {
        Message = "UnSubscribed to Call";        
    }
    public void MakeAPhoneCall(bool notify)
    {
        if (notify)
        {
            PhoneCallEvent+=OnSubscribe;
        }
        else
        {
            PhoneCallEvent+=OnUnSubscribe;
        }
        if(PhoneCallEvent != null)
        {
            PhoneCallEvent.Invoke();
        } 
    }
}
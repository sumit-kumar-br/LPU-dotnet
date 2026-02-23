
using System;

namespace FlexibleInventorySystem.Exceptions
{
    /// <summary>
    /// TODO: Implement custom exception for inventory-specific errors
    /// </summary>
    public class InventoryException : Exception
    {
        // TODO: Add these constructors:
        // - Default constructor
        // - Constructor with message
        // - Constructor with message and inner exception
        // - Constructor with message and error code
        public int ErrorCode { get; }
        public InventoryException()
        {
            
        }
        public InventoryException(string message): base(message)
        {
            
        }
        public InventoryException(string message, Exception innerException): base(message, innerException)
        {
            
        }
        public InventoryException(string message, int errorCode): base(message)
        {
            ErrorCode = errorCode;
        }
        // TODO: Add ErrorCode property
        public override string Message
        {
            get
            {
                if(ErrorCode == 0) return base.Message;
                return $"[Error Code : {ErrorCode}] {base.Message}";
            }
        }
        // TODO: Override Message property to include error code
    }
}

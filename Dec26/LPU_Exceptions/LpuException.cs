namespace LPU_Exceptions
{
    /// <summary>
    /// Custom Exception Class created for LPU Project
    /// </summary> 
    public class LpuException: Exception
    {
        public LpuException(): base() { }
        public LpuException(string errorMsg): base(errorMsg)
        {

        }
    }
}

using System;
using System.Threading;
using System.Threading.Tasks;
	
	class Program  
        {  
            static void Main(string[] args)  
            {  
                Method1();  
                Method2();  
                Console.ReadLine();  
            }  
              
            public static async Task Method1()  
            {  
                await Task.Run(() =>  
                {  
                    for (int i = 0; i < 100; i++)  
                    {  
                        Console.WriteLine("Method 1"+i);  
                    }  
                });             
            }  
      
              
    public static void Method2()  
            {  
                for (int i = 0; i < 25; i++)  
                {  
                    Console.WriteLine(" Method 2");  
                }  
            }  
    }   
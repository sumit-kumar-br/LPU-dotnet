// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

DirectoryDemo dObj = new DirectoryDemo();

// dObj.DirectoryDemoFunc("LPU");

// dObj.DriveInfoFunc("C:\\"); // '\' is an escape charcater; "\\" means '\'

// dObj.PathDemoFunc();

FileStreamDemo fsDemoObj = new FileStreamDemo();
// fsDemoObj.CreateFile(@"c:\CS\LPU-dotnet\FileIODemo\SampleData.txt");
fsDemoObj.ReadFile(@"c:\CS\LPU-dotnet\FileIODemo\SampleData.txt");
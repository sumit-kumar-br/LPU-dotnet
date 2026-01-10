using System.IO;

public class DirectoryDemo
{
    public void DirectoryDemoFunc(string directoryName)
    {
        if (Directory.Exists(directoryName))
        {
            System.Console.WriteLine("Folder already exist..");
        }
        else
        {
            Directory.CreateDirectory(directoryName);
            System.Console.WriteLine("Folder created successfully..");
        }
    }
    public void DriveInfoFunc(string driveName)
    {
        DriveInfo dInfo = new DriveInfo(driveName);
        System.Console.WriteLine($"Drive Name {dInfo.Name}");
        System.Console.WriteLine($"Drive FileSystem {dInfo.DriveType}");
        System.Console.WriteLine($"Drive Size {dInfo.TotalSize}");
        System.Console.WriteLine($"Drive FreeSpace {dInfo.AvailableFreeSpace}");
    }
    public void PathDemoFunc()
    {
        string s = @"C:\CS\LPU-dotnet\FileIODemo\Program.cs";
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
}
// working with files and directories
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Get the current directory
        string currentDirectory = Directory.GetCurrentDirectory();
        Console.WriteLine("Current Directory: " + currentDirectory);

        // Get all files in the current directory
        string[] files = Directory.GetFiles(currentDirectory);
        Console.WriteLine("Files in Current Directory:");
        foreach (string file in files)
        {
            Console.WriteLine(file);
        }

        // Create a new directory
        string newDirectory = Path.Combine(currentDirectory, "NewDirectory");
        Directory.CreateDirectory(newDirectory);
        Console.WriteLine("Created New Directory: " + newDirectory);

        // Create a new file in the new directory
        string newFile = Path.Combine(newDirectory, "NewFile.txt");
        File.WriteAllText(newFile, "Hello, World!");
        Console.WriteLine("Created New File: " + newFile);

        // Read the contents of the new file
        string fileContents = File.ReadAllText(newFile);
        Console.WriteLine("Contents of New File:");
        Console.WriteLine(fileContents);

        // Delete the new file and directory
        File.Delete(newFile);
        Directory.Delete(newDirectory);
        Console.WriteLine("Deleted New File and Directory.");

        // file information
        FileInfo fileInfo = new FileInfo(newFile);
        Console.WriteLine("File Info:");
        Console.WriteLine("File Name: " + fileInfo.Name);
        Console.WriteLine("File Extension: " + fileInfo.Extension);
        Console.WriteLine("File Directory: " + fileInfo.DirectoryName);
        Console.WriteLine("File Exists: " + fileInfo.Exists);

        // file upload example (simulated)
        string uploadDirectory = Path.Combine(currentDirectory, "Upload");
        Directory.CreateDirectory(uploadDirectory);
        string uploadedFile = Path.Combine(uploadDirectory, "UploadedFile.txt");
        File.WriteAllText(uploadedFile, "This is an uploaded file.");
        Console.WriteLine("Simulated File Upload: " + uploadedFile);    
    }
}
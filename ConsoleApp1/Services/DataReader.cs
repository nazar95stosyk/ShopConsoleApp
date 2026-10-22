namespace ConsoleApp1.Services;
using System.IO;

public class DataReader
{
   public string Read(string filePath )
   {
      return File.ReadAllText(filePath);
   }
}
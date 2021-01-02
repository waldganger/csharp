using System;
using System.Collections.Generic;
using System.IO;

namespace TelePrompterConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var lines = ReadFrom("sampleQuotes.txt");
      StreamReader reader = new StreamReader("sampleQuotes.txt");
      string[] array = reader.ReadToEnd().Split(' ');
      // foreach (var line in lines)
      // {
      //   Console.WriteLine(line);
      // }

      StreamWriter writer = new StreamWriter("output.txt");
      foreach (var mot in array)
      {
        writer.WriteLine(mot);
      }
    }

    static IEnumerable<string> ReadFrom(string file)
    {
      string line;
      using (var reader = File.OpenText(file))
      {
        while ((line = reader.ReadLine()) != null)
        {
          yield return line;
        }
      }
    }
  }
}

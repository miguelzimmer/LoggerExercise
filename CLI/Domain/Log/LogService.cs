using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CLI;


internal class LogService

{ 

    
  public List<string> list = new List<string>();
    
  public void LogInformation(string input, string dateTime) 
  {
     Console.WriteLine($"COMO CHEGA NA FUNÇÃO::::: {input}");
        Console.ReadLine();
        list.Add($"Você digitou: {input} às: {dateTime}");
     
  }

  public static void StartLog() 
  {
    Console.WriteLine($"LOG INICIADO EM {DateTime.Now}");
    Console.ReadLine();
  }
  public static void EndLog()
  {
    Console.WriteLine($"LOG FINALIZADO EM {DateTime.Now}");
  }
  public void ListLogs() 
  {
    foreach (var inputs in list)
      {
        Console.WriteLine(inputs);
      }     
  }
  public void GenerateFile()
{
    string logPath = ConfigurationManager.AppSettings["logPath"]!;
    using (StreamWriter write = new StreamWriter(logPath,true))
    {
        foreach (var input in list) 
        {
            write.WriteLine($"{input}");
        }
       
    }
       
}

}

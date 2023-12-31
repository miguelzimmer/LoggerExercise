﻿using System;
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
    
  public void LogInformation(string input) 
  {
    string dateTime = DateTime.Now.ToString();
    list.Add($"{input} às: {dateTime}");
  }

  public void ListLogs() 
  {
    foreach (var inputs in list)
    {
        Console.WriteLine(inputs);
    }
    Console.ReadLine();
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
            Console.WriteLine("Generate File Log in C:\\Temp\\log.txt\"");
        }
       
  }

}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace practice_5
{

  public sealed class Logger
  {
    private static readonly Logger instance = new Logger();

    private static string[] Info = new string[100];
    private static int infoIterator = 0;
    private static string[] Warning = new string[100];
    private static int WarningIterator = 0;
    private static string[] Error = new string[100];
    private static int ErrorIterator = 0;
    private static string[] FullLog = new string[100];
    private static int FinalIterator = 0;

    static Logger()
    {
    }

    private Logger()
    {
    }

    private static void AddtoPool(string message, string[] Pool, int iterator)
    {
      Pool[iterator] = (message);
      FullLog[FinalIterator] = (message);
      FinalIterator++;
      Console.WriteLine(message);
    }

    public static void GetLoggerError(string result)
    {
      Logger.AddtoPool($"Action failed by a reason: {DateTime.Now}, Error: {result}", Error, ErrorIterator);
      ErrorIterator++;
    }

    public static void GetLoggerInfo(string result)
    {
      Logger.AddtoPool($"{DateTime.Now},Info: {result}", Info, infoIterator);
      infoIterator++;

    }

    public static void GetLoggerWarning(string result)
    {
      Logger.AddtoPool($" {DateTime.Now},Warning: {result}", Warning, WarningIterator);
      WarningIterator++;
    }

    public static void FinishLog()
    {
      File.WriteAllLines("log.txt", FullLog);
    }

    public static Logger Instance
    {
      get
      {
        return instance;
      }

    }
  }
}

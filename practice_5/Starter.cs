using System;
namespace practice_5
{
  public class Starter
  {

    public static void Run()
    {

      Random rnd = new Random();
      for (int i = 0; i < 100; i++)
      {
        Result result;
        int j = rnd.Next(1, 4);


        if (j == 1)
        {
          result = Actions.Start();

        }
        else if (j == 2)
        {
          result = Actions.Warning();

        }
        else
        {
          result = Actions.Error();

        }


        if (!result.status)
        {
          Logger.GetLoggerError(result.message);
        }

      }
      Logger.FinishLog();
    }
  }
}

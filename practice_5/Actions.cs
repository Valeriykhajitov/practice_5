using System;
namespace practice_5
{
  public class Actions
  {
    public static Result Start()
    {
      Result result = new Result("Start method:", true);

      Logger.GetLoggerInfo(result.message);
      return result;
    }

    public static Result Warning()
    {
      Result result = new Result("Skipped logic in method", true);
      Logger.GetLoggerInfo(result.message);
      return result;
    }

    public static Result Error()
    {
      return new Result("I broke a logic", false);
    }

  }
}

using System;
namespace practice_5
{
    public class Result
    {
    public string message;
    public bool status { get; }

    public Result(string message, bool status)
    {
      this.message = message;
      this.status = status;
    }
    }
}

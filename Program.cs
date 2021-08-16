using System;
using System.IO;

namespace ConsoleApp1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var directoryName = Path.GetDirectoryName(new Uri(typeof(Confluent.Kafka.Library).Assembly.GetName().EscapedCodeBase).LocalPath);
      Confluent.Kafka.Library.Load(Path.Combine(directoryName, (IntPtr.Size * 8).ToString(), "librdkafka.dll"));

      QueueHelper.SendMessage("test", "message1");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message2");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message3");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message4");

      Console.WriteLine(Guid.NewGuid().ToString());
      QueueHelper.SendMessage("test", "message5");
    }
  }
}

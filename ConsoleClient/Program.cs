using MyMessanger;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Message msg = new Message("RusAl", "Privet", DateTime.UtcNow);
        string output = JsonConvert.SerializeObject(msg);
        Console.WriteLine(output);
        Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
        Console.WriteLine(deserializedMsg);
        /*Console.WriteLine(msg.ToString());*/
        /*{ "UserName":"RusAl","MessageText":"Privet","TimeStamp":"2023-01-02T16:19:41.0451685Z"}
        RusAl < 02.01.2023 16:19:41 >: Privet*/
    }
}
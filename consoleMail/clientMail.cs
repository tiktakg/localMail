using System.Diagnostics;
using System.Net.Sockets;


static class clientMail
{

    static public string host;
    static private int port = 8888;
    static private TcpClient client = new TcpClient();

    static public StreamReader? Reader = null;
    static public StreamWriter? Writer = null;

    static public async Task connectToSever()
    {
        try
        {
            client.Connect(host, port); 
            Reader = new StreamReader(client.GetStream());
            Writer = new StreamWriter(client.GetStream());

            if (Writer is null || Reader is null) 
                return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

   
    static public async Task SendMessageAsync(string msg= "")
    {      
        await Writer.WriteLineAsync(msg);
        await Writer.FlushAsync();
 
    }

    static public async Task<string> ReceiveMessageAsync()
    {
        while (true)
        {
            try
            {
                string? message = await Reader.ReadLineAsync();
                return message;   
            }
            catch
            {
                break;
            }
        }
        return "";
        
    }
   
}





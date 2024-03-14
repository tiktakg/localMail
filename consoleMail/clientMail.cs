using System.Diagnostics;
using System.Net.Sockets;


static class clientMail
{

    static private string host = "192.168.31.219";
    static private int port = 8888;
    static private TcpClient client = new TcpClient();
    static private string? userName = "test3";

    static public StreamReader? Reader = null;
    static public StreamWriter? Writer = null;

    static public async Task connectToSever()
    {
        try
        {
            client.Connect(host, port); //подключение клиента
            Reader = new StreamReader(client.GetStream());
            Writer = new StreamWriter(client.GetStream());
            if (Writer is null || Reader is null) return;

           //Task.Run(() => ReceiveMessageAsync());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    }

    // отправка сообщений
    static public async Task SendMessageAsync(String msg= "")
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

                switch (message[0])
                {
                    case '1':
                        break;
                    case '2':
                        break;
                }
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





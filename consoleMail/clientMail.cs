using System.Diagnostics;
using System.Net.Sockets;


static class clientMail
{

    static public string host = "";// "192.168.31.219";
    static private int port = 8888;
    static private TcpClient client = new TcpClient();

    static public StreamReader? Reader = null;
    static public StreamWriter? Writer = null;

    static bool connectToServer = false;

    static public async Task<bool> connectToSever()
    {
        try
        {
            client.Connect(host, port);
            Reader = new StreamReader(client.GetStream());
            Writer = new StreamWriter(client.GetStream());

            //if (Writer is null || Reader is null)
            //    return;

            connectToServer = true;
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return false;
        }

    }


    static public async Task SendMessageAsync(string msg = "")
    {
        await Writer.WriteLineAsync(msg);
        await Writer.FlushAsync();
    }

    static public async Task<string> ReceiveMessageAsync()
    {
        string? message = "";
        try
        {
            message = await Reader.ReadLineAsync();
        }
        catch
        { }
        return message;
    }

    static public bool isHostNameSet() => host == "";

    static public bool isConnectToServer() => connectToServer;
}

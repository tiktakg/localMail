using consoleMailSever;
using consoleMailSever.entitys;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Text;

ServerObject server = new ServerObject();// создаем сервер
Console.OutputEncoding = Encoding.UTF8;

await server.ListenAsync(); // запускаем сервер

 
class ServerObject
{
    TcpListener tcpListener = new TcpListener(IPAddress.Any, 8888);
    List<ClientObject> clients = new List<ClientObject>(); 
    protected internal void RemoveConnection(string id)
    {
        ClientObject? client = clients.FirstOrDefault(c => c.Id == id);
       
        if (client != null) 
            clients.Remove(client);

        client?.Close();
    }
    protected internal async Task ListenAsync()
    {
       
        try
        {
            tcpListener.Start();
            Console.WriteLine("Сервер запущен. Ожидание подключений...");
 
            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
 
                ClientObject clientObject = new ClientObject(tcpClient, this);
                clients.Add(clientObject);
                Task.Run(clientObject.ProcessAsync);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Disconnect();
        }
    }
 
    
    protected internal async Task BroadcastMessageAsync(string message, string id)
    {
        foreach (var client in  clients)
        {
            if (client.Id != id) // если id клиента не равно id отправителя
            {
                await client.Writer.WriteLineAsync(message); //передача данных
                await client.Writer.FlushAsync();
            }
        }
    }
    // отключение всех клиентов
    protected internal void Disconnect()
    {
        foreach (var client in clients)
        {
            client.Close(); //отключение клиента
        }
        tcpListener.Stop(); //остановка сервера
    }
}
class ClientObject
{
    protected internal string Id { get;} = Guid.NewGuid().ToString();
    protected internal StreamWriter Writer { get;}
    protected internal StreamReader Reader { get;}
 
    TcpClient client;
    ServerObject server; // объект сервера
 
    public ClientObject(TcpClient tcpClient, ServerObject serverObject)
    {
        client = tcpClient;
        server = serverObject;
       
        var stream = client.GetStream(); 
        Reader = new StreamReader(stream);   
        Writer = new StreamWriter(stream);
    }
 
    public async Task ProcessAsync()
    {
        try
        {    
            while (true)
            {
                try
                {
                    string? message = await Reader.ReadLineAsync();

                    jsonMsg jsonMsg = JsonConvert.DeserializeObject<jsonMsg>(message);

                    if (jsonMsg.newUser != null)
                    {

                        Console.WriteLine("Received a new user:");
                        Console.WriteLine(message);

                        if (tools.tryAddNewUser(jsonMsg.newUser, tools.getALlUsers()))
                        {
                            await Writer.WriteLineAsync("2");
                            await Writer.FlushAsync();
                        }
                        else
                        {
                            await Writer.WriteLineAsync("1");
                            await Writer.FlushAsync();
                        }

                    }
                    else if (jsonMsg.msg != null)
                    {
                        Console.WriteLine("Received a new msg:");
                        Console.WriteLine(message);

                        tools.saveMsgToDb(jsonMsg.msg);
                        await server.BroadcastMessageAsync("{\"msg\":" + message + "}",Id);
                        await Writer.WriteLineAsync(message);
                        await Writer.FlushAsync();

                    }
                    else if (jsonMsg.findUser != null)
                    {
                        Console.WriteLine("Received  user:");
                        Console.WriteLine(message);


                        if (tools.isUserExist(jsonMsg.findUser))
                        {
                            await Writer.WriteLineAsync("2");
                            await Writer.FlushAsync();
                        }
                        else
                        {
                            await Writer.WriteLineAsync("1");
                            await Writer.FlushAsync();
                        }
                    }
                    else if(jsonMsg.getAllMsg != null)
                    {
                        Console.WriteLine("Received  all Msg:");

                        string allMsgJson = tools.getAllMsgForCurrentUser(jsonMsg.getAllMsg);
                        await Writer.WriteLineAsync("{\"getAllMsg\":" + allMsgJson + "}");
                        await Writer.FlushAsync();

                    }
                    else
                    {
                        Console.WriteLine("Unknown message type");
                    }



                    await server.BroadcastMessageAsync(message, Id);



                }
                catch
                {
                    Console.WriteLine("catch");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("finally catch");
            server.RemoveConnection(Id);
        }
    }
    

    protected internal void Close()
    {
        Writer.Close();
        Reader.Close();
        client.Close();
    }

   
}


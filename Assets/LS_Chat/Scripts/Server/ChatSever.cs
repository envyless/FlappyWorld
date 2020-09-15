using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UniRx;
using UnityEngine;
using TcpClient = NetCoreServer.TcpClient;

public class ChatSever : MonoBehaviour
{
    public static ChatSever Instance;

    public ReactiveProperty<bool> IsConnected = new ReactiveProperty<bool>();
    public static ChatClient client;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {        
        StartCoroutine(ConnectServer());
        
    }

    IEnumerator ConnectServer()
    {
        string[] args = new string[0];
        // TCP server address
        string address = "127.0.0.1";
        if (args.Length > 0)
            address = args[0];

        // TCP server port
        int port = 1111;
        if (args.Length > 1)
            port = int.Parse(args[1]);

        Debug.Log($"TCP server address: {address}");
        Debug.Log($"TCP server port: {port}");


        // Create a new TCP chat client
        client = new ChatClient(address, port);

        // Connect the client
        Debug.Log("Client connecting...");
        client.ConnectAsync();
        Debug.Log("Done!");

        Debug.Log("Press Enter to stop the client or '!' to reconnect the client...");

        IsConnected.Value = true;
        /*// Perform text input
        for (; ; )
        {
            yield return null;
            ++a;
            if (a > 200)
                a = 0;
            string line = "TEst : "+a;
            if (string.IsNullOrEmpty(line))
                break;

            // Disconnect the client
            if (line == "!")
            {
                Debug.Log("Client disconnecting...");
                client.DisconnectAsync();
                Debug.Log("Done!");
                continue;
            }
            //data
            
            // Send the entered text to the chat server
            //client.SendAsync(line);
        }  */
        yield return null;
    }


    private void OnDestroy()
    {
        // Disconnect the client
        Debug.Log("Client disconnecting...");
        client.DisconnectAndStop();
        Debug.Log("Done!");
    }

    public class ChatClient : TcpClient
    {
        public ChatClient(string address, int port) : base(address, port) { }

        public void DisconnectAndStop()
        {
            _stop = true;
            DisconnectAsync();
            while (IsConnected)
                Thread.Yield();
        }

        protected override void OnConnected()
        {
            Debug.Log($"Chat TCP client connected a new session with Id {Id}");
        }

        protected override void OnDisconnected()
        {
            Debug.Log($"Chat TCP client disconnected a session with Id {Id}");

            // Wait for a while...
            Thread.Sleep(1000);

            // Try to connect again
            if (!_stop)
                ConnectAsync();
        }

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            Debug.Log(Encoding.UTF8.GetString(buffer, (int)offset, (int)size));
        }

        protected override void OnError(SocketError error)
        {
            Debug.Log($"Chat TCP client caught an error with code {error}");
        }

        private bool _stop;
    }
}

using Google.Protobuf;
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
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);        
    }

    private void Start()
    {        
        StartCoroutine(ConnectServer()); 
    }

    IEnumerator ConnectServer()
    {
        string[] args = new string[0];
        // TCP server address, WSL2 carefull this ip,
        string address = "172.26.35.60";
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

        while(!client.IsConnected)
        {
            yield return null;
        }

        this.IsConnected.Value = true;        
        yield return null;
    }


    private void OnDestroy()
    {
        if (Instance != this)
            return;

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
            try
            {
                var req = Google.Protobuf.RequestRPC.Parser.ParseFrom(buffer, (int)offset, (int)size);
                RPCManager.Instance.DoAction(req);
                /*var users = RspUserUpdate.Parser.ParseFrom(buffer, (int)offset, (int)size) as RspUserUpdate;
                if (users == null)
                {
                    Debug.Log(Encoding.UTF8.GetString(buffer, (int)offset, (int)size));
                }
                else
                {
                    foreach (var user in users.Users)
                    {
                        UserMnanger.Instance.UpdateUser(user);
                        Debug.Log("user name : " + user.UserId + "\nx : " + user.X + "\ny : " + user.Y + "\nisdead : " + user.IsDead);
                    }
                }*/

                //Connected
            }
            catch(Exception e)
            {
                Debug.LogError("e : " + e);
            }
        }

        protected override void OnError(SocketError error)
        {
            Debug.Log($"Chat TCP client caught an error with code {error}");
        }

        private bool _stop;
    }
}

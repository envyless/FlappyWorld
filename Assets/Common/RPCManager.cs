using System;
using System.Collections.Generic;
using Google.Protobuf;

public class RPCManager : MonoSingletone<RPCManager>
{
    public Dictionary<RequestRPC.RequestsOneofCase, HashSet<Action<RequestRPC>>> callbacks
        = new Dictionary<RequestRPC.RequestsOneofCase, HashSet<Action<RequestRPC>>>();


    public HashSet<Action<RequestRPC>> GetActions(RequestRPC.RequestsOneofCase requestsOneofCase)
    {
        callbacks.TryGetValue(requestsOneofCase, out var tempCallback);
        if (tempCallback == null)
        {
            tempCallback = new HashSet<Action<RequestRPC>>();
            callbacks.Add(requestsOneofCase, tempCallback);
        }

        return tempCallback;
    }

    public void DoAction(RequestRPC req)
    {
        UnityEngine.Debug.Log("Call Req : " + req);
        var actions = GetActions(req.RequestsCase);
        foreach(var action in actions)
        {
            action.Invoke(req);
        }        
    }

    public void RegistCallback(RequestRPC.RequestsOneofCase requestsOneofCase, System.Action<RequestRPC> callback)
    {
        var actions = GetActions(requestsOneofCase);
        actions.Add(callback);
    }

    public void RemoveCallback(RequestRPC.RequestsOneofCase requestsOneofCase, System.Action<RequestRPC> callback)
    {
        var actions = GetActions(requestsOneofCase);
        actions.Remove(callback);
    }
}
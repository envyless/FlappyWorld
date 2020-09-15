using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class LSRequests : MonoBehaviour
{
    public static LSRequests Instance;

    //data
    public ReactiveProperty<string> UserName = new ReactiveProperty<string>();

    //data Users


    private void Init()
    {
        UserName.Value = PlayerPrefs.GetString("UserName", "");
    }


    public enum Request
    {

    }

    /// <summary>
    /// user name으로 해당 인스턴스에 자신을 알리는 행위
    /// </summary>
    public void ReqLogin(string name)
    {
        PlayerPrefs.SetString("UserName", name);
        UserName.Value = name;
    }

    public struct PacketData
    {

    }

    public Queue<PacketData> packetQues;

    [RuntimeInitializeOnLoadMethod()]
    public static void SetUp()
    {
        var go = new GameObject();
        go.name = "LSRequests";
        Instance = go.AddComponent<LSRequests>();
        Instance.Init();
    }

    public void GetUserName(string deviceUniqueIdentifier)
    {
        
    }    
}

using System;
using System.Collections.Generic;
using Google.Protobuf;
using UnityEngine;

public class UserMnanger : Singletone<UserMnanger>
{
    Queue<ReqUserUpdate> ReqQueue = new Queue<ReqUserUpdate>();

    public void Update()
    {
        while(ReqQueue.Count != 0)
        {
            var req = ReqQueue.Dequeue();
            UpdateUserFromReq(req);
        }
    }


    public Dictionary<string, ReqUserUpdate> dictUsers = new Dictionary<string, ReqUserUpdate>();
    public Dictionary<string, GameObject> dictUserGameObject = new Dictionary<string, GameObject>();

    //push or update user req
    public void UpdateUser(ReqUserUpdate reqUserUpdate)
    {
        ReqQueue.Enqueue(reqUserUpdate);        
    }

    private void UpdateUserFromReq(ReqUserUpdate reqUserUpdate)
    {
        dictUsers.TryGetValue(reqUserUpdate.UserId, out var user);
        if (user == null)
        {
            dictUsers.Add(reqUserUpdate.UserId, reqUserUpdate);
        }
        else
        {
            dictUsers[reqUserUpdate.UserId] = reqUserUpdate;
        }

        //GameObject Update
        UpdateGameObject(reqUserUpdate.UserId, dictUsers[reqUserUpdate.UserId]);

        Console.WriteLine("User Updated : " + reqUserUpdate.UserId);
        Console.WriteLine("Current User Count : " + dictUsers.Count);
    }

    private void UpdateGameObject(string userId, ReqUserUpdate reqUserUpdate)
    {
        if (userId == LSRequests.Instance.UserName.Value)
            return;

        
        dictUserGameObject.TryGetValue(reqUserUpdate.UserId, out var userBird);
        if (userBird == null)
        {
            //new bird User
            var birdPrefab = Resources.Load<GameObject>("Bird");
            var birldUser = GameObject.Instantiate(birdPrefab);

            if (!dictUserGameObject.ContainsKey(userId))
                dictUserGameObject.Add(reqUserUpdate.UserId, birldUser);
            else
                dictUserGameObject[reqUserUpdate.UserId] = birldUser;

            userBird = birldUser;
        }

        var pos = userBird.transform.position;
        pos.x = reqUserUpdate.X;
        pos.y = reqUserUpdate.Y;
        userBird.transform.position = pos;

    }
}
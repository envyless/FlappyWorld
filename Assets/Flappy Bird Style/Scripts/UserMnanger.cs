using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using UnityEngine;

public class UserMnanger : Singletone<UserMnanger>
{
    Queue<RequestRPC> ReqQueue = new Queue<RequestRPC>();
    List<User> Users = new List<User>();

    public void Update()
    {

        for(int i = 0; i< Users.Count; ++i)
        {
            UpdateUserFromReq(Users[i]);
        }
        Users.Clear();

        /*while(Users.Count != 0)
        {
            var req = ReqQueue.Dequeue();
        }*/
    }


    public Dictionary<string, User> dictUsers = new Dictionary<string, User>();
    public Dictionary<string, GameObject> dictUserGameObject = new Dictionary<string, GameObject>();

    private void UpdateUserFromReq(User User)
    {        
        dictUsers.TryGetValue(User.UserId, out var user);
        if (user == null)
        {
            dictUsers.Add(User.UserId, User);
        }

        dictUsers[User.UserId] = User;
        user = User;

        //GameObject Update
        UpdateGameObject(User.UserId, dictUsers[User.UserId]);

        Console.WriteLine("User Updated : " + User.UserId);
        Console.WriteLine("Current User Count : " + dictUsers.Count);
    }

    internal void SetUp()
    {
        RPCManager.Instance.RegistCallback(RequestRPC.RequestsOneofCase.ReqUsersUpdate, UpdateUsers);
    }

    private void UpdateUsers(RequestRPC obj)
    {
        var reqUsersUpdates = obj.ReqUsersUpdate;
        if (reqUsersUpdates == null)
            return;

        Users = reqUsersUpdates.Users.ToList();
    }

    private void UpdateGameObject(string userId, User user)
    {
        if (userId == LSRequests.Instance.UserName.Value)
            return;

        dictUserGameObject.TryGetValue(user.UserId, out var userBird);
        if (userBird == null)
        {
            //new bird User
            var birdPrefab = Resources.Load<GameObject>("Bird");
            var birldUser = GameObject.Instantiate(birdPrefab);

            if (!dictUserGameObject.ContainsKey(userId))
                dictUserGameObject.Add(user.UserId, birldUser);
            else
                dictUserGameObject[user.UserId] = birldUser;

            userBird = birldUser;
        }
        var pos = userBird.transform.position;
        pos.x = user.X;
        pos.y = user.Y;
        userBird.transform.position = pos;

    }
}
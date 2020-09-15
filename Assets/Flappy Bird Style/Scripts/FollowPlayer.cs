using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    private Text text;

    private void Start()
    {
        text = GetComponent<Text>();
        LSRequests.Instance.UserName.Subscribe(_userName =>
        {
            text.text = _userName;
        });
    }

    // Start is called before the first frame update
    void LateUpdate()
    {
        if (target == null)
            return;

        transform.position = target.position.GetScreenPosFromWorldPos();
    }

    public void SetTarget(Transform _target)
    {
        target = _target;
    }
}

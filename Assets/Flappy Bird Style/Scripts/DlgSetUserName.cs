using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DlgSetUserName : MonoBehaviour
{
    public InputField inputField;

    //check Input name is need to show?
    private void Start()
    {
        if(LSRequests.Instance.UserName.Value != "")
        {
            gameObject.SetActive(false);
            return;
        }
    }

    public void OnClickEnter()
    {
        LSRequests.Instance.ReqLogin(inputField.text);
        gameObject.SetActive(false);
    }
}

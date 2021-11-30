using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetButton : MonoBehaviour
{
    private Button btn;
    public ItemActor item;
    public int count;
    public void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() => { SpawnPopUp(); });
    }

    void SpawnPopUp()
    {
        Injects._ui.popUpСontroller.SetPopUp(item,count);
    }
}

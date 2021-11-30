using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PopUpСontroller : MonoBehaviour
{
    public List<PopUp> PopUps = new List<PopUp>();
    public Image Mask;
    public Transform popUpContainer;
    public PopUp popUpData;
    
    public void SetPopUp(ItemActor item,int count)
    {
        var popUp = Instantiate(popUpData, popUpContainer);
        var a = Instantiate(item, popUp.ItemContainer);
            a.Count.text = count.ToString();
            popUp.ActiveItem = a;
            PopUps.Add(popUp);
            popUp.Show();
    }
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            var popUp = transform.GetChild(i).GetComponent<PopUp>();
            if (popUp)
            {
                PopUps.Add(popUp);    
            }
        }
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            DisableLastPopUp();   
        }
    }
    
    private void Disable()
    {
        Mask.gameObject.SetActive(false);
    }

    public void RemovePopUp(PopUp popUp)
    {
        PopUps.Remove(popUp);
        if (PopUps.Count == 0)
        {
            MaskHide();
        }
    }
    public void MaskHide()
    {
        Mask.DOColor(Injects._staticData.hideMaskColor, Injects._staticData.hideMaskDuration)
            .SetEase(Injects._staticData.hideMaskCurve).OnComplete(Disable);
    }
    public void MaskShow()
    {
        Mask.gameObject.SetActive(true);
        Mask.color = Injects._staticData.hideMaskColor;
        Mask.DOColor(Injects._staticData.showMaskColor, Injects._staticData.showMaskDuration)
            .SetEase(Injects._staticData.showMaskCurve);
    }
    public void DisableLastPopUp()
    {
        bool oneDisable = false;
        int countActive = 0;
        for (var i = PopUps.Count - 1; i >= 0; i--)
        {
            var item = PopUps[i];
            if (item.gameObject.activeSelf)
            {
                if (!oneDisable)
                {
                    item.Hide();
                    oneDisable = true;
                    PopUps.Remove(item);
                    continue;
                }

                countActive++;
            }
        }

        if (countActive == 0)
        {
            MaskHide();
        }
        
        
    }
}

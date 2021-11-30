using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEditor;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public Transform ItemContainer;
    public ItemActor ActiveItem;
    public CanvasGroup group;
    
    public void DeleteItem()
    {
        Destroy(gameObject);
    }

    public void Show()
    {
        
        Injects._ui.popUpСontroller.MaskShow();
        transform.localScale = Injects._staticData.hideEndScalePopUpValue;
        @group.DOFade(Injects._staticData.showFadeValue, Injects._staticData.showFadeDuration);
        gameObject.SetActive(true);
        transform.DOScale(Injects._staticData.showEndScalePopUpValue, Injects._staticData.showScaleDuration).SetEase(Injects._staticData.showScaleCurve);
        
    }
    public void Hide()
    {
        Injects._ui.popUpСontroller.RemovePopUp(this);
        transform.DOScale(Injects._staticData.hideEndScalePopUpValue, Injects._staticData.hideScaleDuration)
            .SetEase(Injects._staticData.hideScaleCurve).OnComplete( Disable);
        @group.DOFade(Injects._staticData.hideFadeValue, Injects._staticData.hideFadeDuration);

    }
    private void Disable()
    {
        gameObject.SetActive(false);
        DeleteItem();
    }

    
}

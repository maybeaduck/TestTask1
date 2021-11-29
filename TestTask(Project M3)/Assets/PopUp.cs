using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public void Show()
    {
        transform.localScale = Injects._staticData.hideEndScalePopUpValue;
        gameObject.SetActive(true);
        transform.DOScale(Injects._staticData.showEndScalePopUpValue, Injects._staticData.showScaleDuration).SetEase(Injects._staticData.showScaleCurve);
    }
    public void Hide()
    {
        transform.DOScale(Injects._staticData.hideEndScalePopUpValue, Injects._staticData.hideScaleDuration)
            .SetEase(Injects._staticData.hideScaleCurve).OnComplete( Disable);
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}

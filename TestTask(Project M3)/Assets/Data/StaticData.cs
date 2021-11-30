using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

[CreateAssetMenu()]
public class StaticData : ScriptableObject
{
    public Vector3 showEndScalePopUpValue;
    public float showScaleDuration;
    public AnimationCurve showScaleCurve;
    public Vector3 hideEndScalePopUpValue;
    public float hideScaleDuration;
    public AnimationCurve hideScaleCurve;
    public Color hideMaskColor;
    public float hideMaskDuration;
    public AnimationCurve hideMaskCurve;
    public Color showMaskColor;
    public float showMaskDuration;
    public AnimationCurve showMaskCurve;
    public float hideFadeValue;
    public float hideFadeDuration;
    public float showFadeValue;
    public float showFadeDuration;
}

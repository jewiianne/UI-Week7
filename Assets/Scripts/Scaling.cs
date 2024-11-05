using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Scaling : MonoBehaviour
{
    public GameObject knuckles;

    [Header("Scale Up")]
    public Vector3 scaleUpSize;
    public Vector3 originalSizeScaleUp;
    public float animationSpeedScaleUp;
    private bool isScaledUp = false;

    [Header("Scale Down")]
    public Vector3 scaleDownSize;
    public Vector3 originalSizeScaleDown;
    public float animationSpeedScaleDown;
    private bool isScaledDown = false;

    public void ScaleUp()
    {
        if (!isScaledUp)
        {
            knuckles.transform.DOScale(scaleUpSize, animationSpeedScaleUp).OnComplete(() => isScaledUp = true);
        }
        else
        {
            knuckles.transform.DOScale(originalSizeScaleUp, animationSpeedScaleUp).OnComplete(() => isScaledUp = false);
        }
    }

    public void ScaleDown()
    {
        if (!isScaledDown)
        {
            knuckles.transform.DOScale(scaleDownSize, animationSpeedScaleDown).OnComplete(() => isScaledDown = true);
        }
        else
        {
            knuckles.transform.DOScale(originalSizeScaleDown, animationSpeedScaleDown).OnComplete(() => isScaledDown = false);
        }
    }
}
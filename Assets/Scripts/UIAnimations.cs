using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnimations : MonoBehaviour
{
    [SerializeField] private Transform popupObject;

    private void Start()
    {
        popupObject.position = new Vector2(popupObject.position.x, -200);
    }

    public void ShowPopUp()
    {
        popupObject.position = new Vector2(popupObject.position.x, -200);
        popupObject.DOMoveY(100, 3.0f).SetEase(Ease.OutElastic);
    }
}

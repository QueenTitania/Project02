using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardScript : MonoBehaviour
{
    public int value = 0;

    public int GetCardValue()
    {
        return value;
    }

    public void SetCardValue(int val)
    {
        value = val;
    }

    public void SetSprite(Sprite spr)
    {
        gameObject.GetComponent<Image>().sprite = spr;
    }

    public void ResetCard()
    {
        gameObject.GetComponent<Image>().sprite = null;
        value = 0;
    }


}

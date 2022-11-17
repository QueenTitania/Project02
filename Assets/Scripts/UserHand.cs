using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserHand : MonoBehaviour
{

    public DeckManager deckScript;
    [SerializeField] public GameObject cardPrefab;

    public int handValue;

    public GameObject[] hand;
    public int cardIndex = 0;
    
    public void Start()
    {
        hand = new GameObject[9];
    }

    public void GetCard()
    {
        //int cardValue = deckScript.DealCard(hand[cardIndex].GetComponent<CardScript>());
        hand[cardIndex] = deckScript.DealCard(cardPrefab, this.gameObject);
        //int cardValue = hand[cardIndex].GetComponent<CardScript>().GetCardValue();

        //hand[cardIndex].GetComponent<Renderer>().enabled = true;
        cardPrefab.GetComponent<Renderer>().enabled = true;
        handValue += hand[cardIndex].GetComponent<CardScript>().GetCardValue();
        cardIndex++;
        Debug.Log("hand value: " + handValue);
    }

    public int GetHandValue()
    {
        return handValue;
    }

    public void ClearHand()
    {
        
        for(int x=hand.Length-1; x>=0; x--)
        {
            if(hand[x] != null)
            Destroy(hand[x]);
        }
        handValue = 0;
        cardIndex = 0;
    }

}

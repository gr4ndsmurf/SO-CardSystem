using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardInfo")]
public class CardInfo : ScriptableObject
{
    public string cardName, description;
    public int attack, shield, heart;
    public Sprite backgroundImg, characterImg, attackPhoto;
    public GameObject prefab;
}

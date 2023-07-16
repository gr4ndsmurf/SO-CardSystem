using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IDragHandler,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] private TextMeshProUGUI cardName;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI attack;
    [SerializeField] private TextMeshProUGUI shield;
    [SerializeField] private TextMeshProUGUI heart;
    [SerializeField] private Image cardBackground;
    [SerializeField] private Image characterPhoto;
    [SerializeField] private Image attackPhoto;

    public CardInfo cardInfo;

    [SerializeField] private RectTransform cardRect;

    private Vector3 firstPos;

    public void Start()
    {
        cardName.text = cardInfo.cardName;
        description.text = cardInfo.description;
        attack.text = cardInfo.attack.ToString();
        shield.text = cardInfo.shield.ToString();
        heart.text = cardInfo.heart.ToString();
        cardBackground.sprite = cardInfo.backgroundImg;
        characterPhoto.sprite = cardInfo.characterImg;
        attackPhoto.sprite = cardInfo.attackPhoto;

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        cardRect.localScale = new Vector3(1.5f, 1.5f, 1.5f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        cardRect.localScale = new Vector3(1, 1, 1);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        firstPos = cardRect.position;
        cardRect.localScale = new Vector3(1, 1, 1);
    }

    public void OnDrag(PointerEventData eventData)
    {
        cardRect.position = eventData.position;
        cardRect.localScale = new Vector3(1, 1, 1);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.position.y > 500)
        {
            CardController.Instance.InstantiateCard(this);
        }
        else
        {
            cardRect.position = firstPos;
        }
    }

}

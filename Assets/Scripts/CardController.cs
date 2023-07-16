using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public static CardController Instance;

    public Vector3 offset;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }

        Instance = this;
    }

    public void InstantiateCard(Card sender)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out var hit);
        Instantiate(sender.cardInfo.prefab, hit.point + offset, Quaternion.Euler(Vector3.zero));
        sender.gameObject.SetActive(false);
    }
}

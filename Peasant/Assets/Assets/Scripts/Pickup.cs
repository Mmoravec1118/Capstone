using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Pickup : MonoBehaviour
{
    public GameObject uIBit;
    public string pickUpText;
    public Sprite uIImage;
    // Use this for initialization

    void Action()
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>().inventory.Add(this);
#pragma warning restore CS0436 // Type conflicts with imported type
        Destroy(gameObject);
        uIBit.SetActive(true);
        uIBit.GetComponent<RectTransform>().sizeDelta = uIImage.rect.size;
        uIBit.GetComponent<Image>().sprite = uIImage;
        uIBit.GetComponent<UIPickup>().text.text = pickUpText;
    }
}

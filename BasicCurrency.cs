using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicCurrency : MonoBehaviour {

    public int Coins = 1000;

    public int ItemPrice = 100;

    public bool WeaponIsLocked = true;

    public GameObject Weapon;

    public Text CoinsAmount;

    public Text ItemPriceText;

	// Use this for initialization
	void Start () {


        CheckCoins();

	}

    public void CheckCoins()
    {
        CoinsAmount.text = Coins.ToString();
    }

    public void DisplayItemPrice()
    {
        ItemPriceText.text = ("Scar L Price " + ItemPrice + " Coins");
    }

    public void UnlockItem()
    {
        if (WeaponIsLocked == true)
        {
            if (Coins >= ItemPrice)
            {
                Coins -= ItemPrice;

                Weapon.SetActive(true);

                WeaponIsLocked = false;
            }
        }
        if (WeaponIsLocked == false)
        {
            Debug.Log("You already have this weapon unlocked");
        }
    }
	
	// Update is called once per frame
	void Update () {

        CheckCoins();
        DisplayItemPrice();

	}
}

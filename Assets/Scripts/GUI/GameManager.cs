using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour {


    [SerializeField]
    GameObject shopMenu;
    [SerializeField]
    private bool shopIsOpen;


    
    void Start () {
        //set shop to inactive on start
        shopMenu.SetActive(false);
        shopIsOpen = false;
	}
	
	
	void Update () {
        //open/close shop menu when tab is pressed
        if(Input.GetKeyDown(KeyCode.Tab)) {
            if (shopIsOpen == false)
            {
                //animate - shopOpen
                shopMenu.SetActive(true);
                shopIsOpen = true;
            }
            else
            {
                //animate - shopClosed
                shopMenu.SetActive(false);
                shopIsOpen = false;
            }   
        }
    }

    public void CatapultPurchase()
    {
        //if money >= amount to buy catapult
            //instantiate catapult
        //if catapult is placed
            // money - amount
        Debug.Log("you bought a catapult");
    }
}

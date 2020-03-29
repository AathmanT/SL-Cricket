using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour {


    float legCoinPercentage, handCoinPercentage;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        legCoinPercentage = (GM.legCoinTotal / 14) * 100.0f;
        handCoinPercentage = (GM.handCoinTotal / 10) * 100.0f;

        if (gameObject.name=="coinsTxt"){
            GetComponent<TextMesh>().text = "Total Coins : " + GM.coinTotal;
        }

        if (gameObject.name == "legCoinsTxt")
        {
             GetComponent<TextMesh>().text = "Leg health : " + GM.legCoinTotal + "/" + 14 + " coins  ( " + System.Math.Round(legCoinPercentage,2)+"% )";
            //GetComponent<TextMesh>().text = "hi";
            
        }

        if (gameObject.name == "handCoinsTxt")
        {
            GetComponent<TextMesh>().text = "Hand health : " + GM.handCoinTotal +"/"+ 10+" coins  ( " + System.Math.Round(handCoinPercentage,2) + "% )";
           // GetComponent<TextMesh>().text = "hi";
        }
       

        if (gameObject.name == "coinsDisplayTxt")
        {
            GetComponent<TextMesh>().text = "Coins : " + GM.coinTotal;
        }

        if (gameObject.name=="timeTxt"){
            GetComponent<TextMesh>().text = "Time : " + GM.timeTotal;
        }
        if (gameObject.name=="status")
        {
            GetComponent<TextMesh>().text =GM.lvlCompleteStatus;
        }

        
	}
}

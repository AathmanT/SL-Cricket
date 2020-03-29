using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour {

    public static float verticalVelocity=0;
    public static float coinTotal,legCoinTotal,handCoinTotal;
    public static float timeTotal;
    public static int zVelocityAdjustment=1;
    public static string lvlCompleteStatus = "";
    public float waitToLoad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeTotal += Time.deltaTime;

        if (GM.lvlCompleteStatus == "Fail")
        {
            waitToLoad += Time.deltaTime;
        
        }
        if (waitToLoad>2)
        {
            SceneManager.LoadScene("SinglePlayer");
        }

	}
}

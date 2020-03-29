using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveOrb : MonoBehaviour
{


    public KeyCode moveLeft;
    public KeyCode moveRight;

    public float horizontalVelocity;
    public int laneNumber = 2;
    public bool controlLocked;

    public Transform boomObject;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horizontalVelocity, GM.verticalVelocity, 4);

        if (Input.GetKeyDown(moveLeft) && laneNumber > 1 && controlLocked == false)
        {
            horizontalVelocity = -2;
            StartCoroutine(stopSlide());
            laneNumber -= 1;
            controlLocked = true;
        }

        if (Input.GetKeyDown(moveRight) && laneNumber < 3 && controlLocked == false)
        {
            horizontalVelocity = 2;
            StartCoroutine(stopSlide());
            laneNumber += 1;
            controlLocked = true;
        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "rampBottomTrig")
        {
            GM.verticalVelocity = 2;
        }
        if (other.gameObject.name == "rampTopTrig")
        {
            GM.verticalVelocity = 0;
        }

        if (other.gameObject.name == "Quad")
        {

            GM.lvlCompleteStatus = "You Won";
            SceneManager.LoadScene("LevelComplete");
        }
    }

    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "lethal")
        {
            Destroy(gameObject);
            GM.zVelocityAdjustment = 0;
            GM.lvlCompleteStatus = "Fail";
            Instantiate(boomObject, transform.position, boomObject.rotation);
        }

        if (other.gameObject.name == "Capsule")
        {

            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "coin")
        {

            Destroy(other.gameObject);
            GM.coinTotal += 1;
        }


    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(0.5f);
        horizontalVelocity = 0;
        controlLocked = false;
    }
}

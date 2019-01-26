using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    public int playerNumber = 1;
    public string horizontalCtrl = "Horizontal_P1";
    public string verticalCtrl = "Vertical_P1";
    public string fireButton = "Fire1_P1";

    public int boozeCapacity = 0;
    public Slider boozeSlider;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If the fire button is pressed
        if (Input.GetButton(fireButton))
        {
            //print("Vomit or clean");
            if (playerNumber == 1)
            {
                VacuumScript.vacuuming = true;
            }
            else
            {
                GetComponent<VomitScript>().puke(playerNumber);
            }
        }
    }

    private void FixedUpdate()
    {
        // Cache the horizontal input
        float h = Input.GetAxis(horizontalCtrl);
        // Cache the vertical input
        float v = Input.GetAxis(verticalCtrl);
        //GetComponent<VomitScript>().Move(h, v);

        GetComponent<VomitScript>().turn(v, h);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (playerNumber != 1 && other.GetComponent<PlayerControl>().playerNumber == 1)
        {
            transform.position = new Vector3(0, 1, -1);
        }
    }
}

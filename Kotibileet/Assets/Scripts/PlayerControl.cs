using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public int playerNumber = 1;
    public string horizontalCtrl = "Horizontal_P1";
    public string verticalCtrl = "Vertical_P1";
    public string fireButton = "Fire1_P1";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // If the fire button is pressed
        if (Input.GetButtonDown(fireButton))
        {
            //print("Vomit or clean");
            GetComponent<VomitScript>().puke(playerNumber);
        }
    }

    private void FixedUpdate()
    {
        // Cache the horizontal input
        float h = Input.GetAxis(horizontalCtrl);
        // Cache the vertical input
        float v = Input.GetAxis(verticalCtrl);
        GetComponent<VomitScript>().Move(h, v);
    }
}

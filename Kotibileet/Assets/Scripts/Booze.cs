using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booze : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerControl>().playerNumber == 1)
            return;

        Debug.Log("entered");
        gameObject.SetActive(false);
        //here add booze to player
        if (other.GetComponent<PlayerControl>().boozeCapacity < 120)
        {
            other.GetComponent<PlayerControl>().boozeCapacity=+ 60;
            other.GetComponent<PlayerControl>().boozeSlider.value=+60;
        }
    }
}

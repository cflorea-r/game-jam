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
        Debug.Log("entered");
        gameObject.SetActive(false);
        //here add booze to player
    }
}

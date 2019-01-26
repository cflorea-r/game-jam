using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumScript : MonoBehaviour
{
    GameObject attractedTo;
    float step = 0.2f;
    public static bool vacuuming;

    // Start is called before the first frame update
    void Start()
    {
        attractedTo = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (vacuuming == true)
        {
            if (Vector3.Distance(attractedTo.transform.position, transform.position) <= 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, attractedTo.transform.position, step);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.GetComponent<PlayerControl>() == true)
        {
            if (other.GetComponent<PlayerControl>().playerNumber == 1)
            {
                gameObject.SetActive(false);
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacuumScript : MonoBehaviour
{
    public GameObject attractedTo;
    float step = 0.2f;
    public static bool vacuuming;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(vacuuming == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, attractedTo.transform.position, step);
        }
    }
}

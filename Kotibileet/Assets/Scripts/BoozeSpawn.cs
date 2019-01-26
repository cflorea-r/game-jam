using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoozeSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn()
    {
        int randomIndex = Random.Range(0, transform.childCount - 1);
        transform.GetChild(randomIndex).gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VomitScript : MonoBehaviour
{
    public Transform vomitPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            puke();
        }

        if(Input.GetKey(KeyCode.UpArrow))
        { 
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0.1f, 0);
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, -0.1f, 0);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0.1f, 0, 0);
        }

    }

    public void puke()
    {
        Transform vomitParticle = Instantiate(vomitPrefab, gameObject.transform.position, Quaternion.identity);
        vomitParticle.GetComponent<Rigidbody2D>().velocity = new Vector3(15, Random.Range(-3, 3), 0);
        Debug.Log("Space pressed");
    }

}

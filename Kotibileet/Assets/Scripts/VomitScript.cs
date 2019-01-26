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
    }

    public void puke()
    {
        Transform vomitParticle = Instantiate(vomitPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        vomitParticle.GetComponent<Rigidbody2D>().velocity = new Vector3(15, Random.Range(-3, 3), 0);
        Debug.Log("Space pressed");
    }

    public GameObject PullOBJ;
    public float ForceSpeed;

    public void OnTriggerStay(Collider coll)
    {

        Debug.Log("Vomit detected!");

        if (coll.gameObject.tag == ("Vacuumable"))
        {
            PullOBJ = coll.gameObject;

            PullOBJ.transform.position = Vector3.MoveTowards
                (PullOBJ.transform.position,
                 transform.position,
                 ForceSpeed * Time.deltaTime);
        }

    }
}

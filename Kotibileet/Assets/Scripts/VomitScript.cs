using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VomitScript : MonoBehaviour
{
    public Transform vomitPrefab;
    public float rotationSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("space"))
        //{
        //    puke();
        //}

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    gameObject.transform.position = gameObject.transform.position + gameObject.transform.up * 0.1f;
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    gameObject.transform.position = gameObject.transform.position + gameObject.transform.up * -0.1f;
        //}


        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    gameObject.transform.position = gameObject.transform.position + new Vector3(-0.1f, 0, 0);
        //    transform.Rotate(Vector3.back * 250.0f * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    gameObject.transform.position = gameObject.transform.position + new Vector3(0.1f, 0, 0);
        //    transform.Rotate(Vector3.forward * 250.0f * Time.deltaTime);
        //}

    }

    public void puke(int playerNumber)
    {
        if (GetComponent<PlayerControl>().boozeCapacity > 0)
        {
            Transform vomitParticle = Instantiate(vomitPrefab, gameObject.transform.position, Quaternion.identity);
            //vomitParticle.GetComponent<Rigidbody2D>().velocity = new Vector3(15, Random.Range(-3, 3), 0);
            vomitParticle.GetComponent<VomitProjectileScript>().setOwner(playerNumber);
            vomitParticle.GetComponent<Rigidbody2D>().velocity = gameObject.transform.up * 15;

            GetComponent<PlayerControl>().boozeCapacity--;
            GetComponent<PlayerControl>().boozeSlider.value--;
        }
    }

    public void Move(float horizontal, float vertical)
    {
        horizontal *= .1f;
        vertical *= .1f;
        gameObject.transform.position = gameObject.transform.position + new Vector3(horizontal, vertical, 0);
    }

}

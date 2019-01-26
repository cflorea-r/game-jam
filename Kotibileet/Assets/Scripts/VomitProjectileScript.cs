using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VomitProjectileScript : MonoBehaviour
{
    public Transform stainPrefab;

    public float lifeTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnDestroy()
    {
        Transform stain = Instantiate(stainPrefab, gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

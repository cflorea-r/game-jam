using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VomitProjectileScript : MonoBehaviour
{
    public Transform stainPrefab;
    public ScoreScript scoreScript;
    int owner;

    public float lifeTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>();
        Destroy(gameObject, lifeTime);
    }

    private void OnDestroy()
    {
        Transform stain = Instantiate(stainPrefab, gameObject.transform.position, Quaternion.identity);

        scoreScript.AddScore(owner);

        scoreScript.printScores();
    }

    public void setOwner(int playerNumber)
    {
        owner = playerNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

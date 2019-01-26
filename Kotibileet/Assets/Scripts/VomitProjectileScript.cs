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
        switch (owner)
        {
            case 2:
                stain.GetComponent<SpriteRenderer>().color = new Color(0.35f, 0.73f, 0.37f, 1.0f);
                break;
            case 3:
                stain.GetComponent<SpriteRenderer>().color = new Color(0.73f, 0.4f, 0.35f, 1.0f);
                break;
            case 4:
                stain.GetComponent<SpriteRenderer>().color = new Color(0.73f, 0.6f, 0.2f, 1.0f);
                break;
        }
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

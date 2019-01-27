using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreReset : MonoBehaviour
{

    public ScoreScript scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>();
        scoreScript.resetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

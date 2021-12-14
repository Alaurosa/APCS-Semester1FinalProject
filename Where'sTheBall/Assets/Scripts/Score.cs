using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class Score : MonoBehaviour
{

    public TMP_Text timerText;
    public static int scoreValue = 0;
    public Transform teleportTarget;
    public GameObject Player;
    TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TMP_Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

        if(scoreValue == 5){
            Teleport();
            scoreValue = 0;
        }
    }

    void Teleport(){
        Player.transform.position = teleportTarget.transform.position;
    }
}

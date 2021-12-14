using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private int countDownTime;

    private void Start(){
        StartCoroutine(CountDownStart());
    }

    IEnumerator CountDownStart(){
        while(countDownTime > 0){
            timerText.text = countDownTime.ToString();

            yield return new WaitForSeconds(1f);

            countDownTime--;
        }
    }
}

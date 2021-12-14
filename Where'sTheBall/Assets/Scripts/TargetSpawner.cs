using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    
    public Transform spawnPos;
    public GameObject spawnee;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)){
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
    }
}

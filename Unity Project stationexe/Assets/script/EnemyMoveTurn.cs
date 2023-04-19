using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveTurn : MonoBehaviour
{
    private float chargeTime = 5.0f;
    private float timeCount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;

        transform.position += transform.forward *Time.deltaTime;
        //指定時間の経過
        if(timeCount > chargeTime) 
        {
            transform.position -= transform.forward *Time.deltaTime;

            timeCount = 0;
        }
    }
}

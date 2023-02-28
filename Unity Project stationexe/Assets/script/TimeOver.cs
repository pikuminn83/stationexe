using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeOver : MonoBehaviour
{
    private float counttime= 0.0f;//時間をはかる
    public float timLimet = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counttime += Time.deltaTime;

        if(counttime> timLimet)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

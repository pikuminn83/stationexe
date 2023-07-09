using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class TimeOver : MonoBehaviour
{
    public string Enemy;
    private float counttime= 0.0f;//時間をはかる
    public float timLimet = 0.0f;


    [SerializeField]
    TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timLimet -= Time.deltaTime;

        if(counttime> timLimet)
        {
            SceneManager.LoadScene("GameOver");
        }
        //timeを表示する
        timeText.text = "TimeLimet:"+timLimet.ToString("N2");

    }
   void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Hit");
        if(collision.gameObject.tag == "Enemy")
        {

            transform.LookAt(collision.transform);
 
            Invoke("Scenechenge",1.0f);
        }

    }
    void Scenechenge()
    {
         SceneManager.LoadScene("GameOver");
    }

}

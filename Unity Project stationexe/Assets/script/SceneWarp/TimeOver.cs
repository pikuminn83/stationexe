using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeOver : MonoBehaviour
{
    public string Enemy;
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
    private void OnCollisionEnter(Collision col)
    {
        //Debug.Log("Hit");
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit2");
        }

    }
    
}

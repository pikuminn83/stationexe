using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("a");
        Invoke("ChangeScene",0.01f);
    }

    // Update is called once per frame
    void ChangeScene()
    {
          //Debug.Log("b");
        SceneManager.LoadScene("StationGameStage2");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameClearscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        Invoke("ChangeSceneGameClear", 0.01f);
    }
    void ChangeSceneGameClear()
    {
        //Debug.Log("b");
        SceneManager.LoadScene("GameClear");
    }

}

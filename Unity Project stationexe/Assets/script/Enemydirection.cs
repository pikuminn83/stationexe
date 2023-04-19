using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydirection : MonoBehaviour
{
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player= GameObject.Find("HeadJoint");
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの方をオブジェクトが向くようにする。
        transform.LookAt(Player.transform);
    }
}

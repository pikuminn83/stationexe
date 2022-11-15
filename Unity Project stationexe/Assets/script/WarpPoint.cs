using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public Vector3 pos;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision){
     collision.gameObject.transform.position= new Vector3(pos.x,pos.y,pos.z);
    }
}

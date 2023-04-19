using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


//オブジェクトにNaveMeshAgentコンポーネントを設置
[RequireComponent(typeof(NavMeshAgent))]
public class playersarti : MonoBehaviour
{
    public Transform[] points;
    [SerializeField] int destPoint = 0;
    private NavMeshAgent agent;

    Vector3 playerPos;
    GameObject player;
    float distance;
    [SerializeField] float trackingRange=3f;
    [SerializeField] float quitRange = 5f;
    [SerializeField] bool tracking = false;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //autoBraking を無効にすると、目標地点の間を継続的に移動します
        //(つまり、エージェントは目標地点に近づいても
        //速度をおとしません)
        agent.autoBraking = false;

        GotoNextPoint();
        //追跡したいオブジェクトの名前を入れる
        player = GameObject.Find("player");
    }
    void GotoNextPoint()
    {
        //地点が何も設定されていないとき
        if(points.Length == 0){
         return; 
         }
    //エージェントが現在設定された目標地点に行くようにする
         agent.destination=points[destPoint].position;
        //配列内の次の位置を目標地点に設定し
        //必要ならば出発地点にもどります
         destPoint = (destPoint+1)%points.Length;
       

    }
    void Update()
    {
    //playerとこのオブジェクトの距離を測る
        playerPos = player.transform.position;
        //distanceの位置座標
        distance = Vector3.Distance(this.transform.position,playerPos);

        if(tracking)
        {
            //追跡の時,quitRangeにより距離が離れたら中止
            if(distance > quitRange){
                tracking = false;
                //Playeを目標にする
                agent.destination=playerPos;
            }
            else
            {
                //
                if(distance < trackingRange){
                    tracking = true;
                }
                //エージェントが現目標地点にちかずいてきたら
                //次の目標地点を選択します
                if(!agent.pathPending && agent.remainingDistance<0.5f){
                    GotoNextPoint();
                }
            }
        }
        void OnDrawGizmosSelected()
        {
            //trackingRangeの範囲を赤いワイヤーフレームで示す
            Gizmos.color=Color.red;
            //意味を調べる
            Gizmos.DrawWireSphere(transform.position,trackingRange);

            //trackingRangeの範囲を赤いワイヤーフレームで示す
            Gizmos.color=Color.blue;
            Gizmos.DrawWireSphere(transform.position,quitRange);
        }
    }

   
}

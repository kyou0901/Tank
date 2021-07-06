using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMove : MonoBehaviour
{
    [SerializeField]
    private float balletSpeed = 1.6f;
    Vector3 parentDir;
    void Start()
    {
        //親の方向を取得、格納そのあとに親子関係をリセット
        parentDir = transform.parent.forward;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( parentDir*balletSpeed*Time.deltaTime );
    }

    private void OnCollisionEnter( Collision collision ) {
        //タンクに当たったら、爆発のエフェクトを呼ぶ
        if(collision.transform.tag == "Tank") {
          
            StartCoroutine( collision.gameObject.GetComponent<BreakMotion>().DeadEffectCombo(collision.gameObject) );
         
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletDelete : BalletBehaviour
{
    float deleteTime = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void BalletAction() {
        deleteTime -= Time.deltaTime;
        if(deleteTime <= 0) {
     
            //たまを削除
            Destroy( gameObject );

            //球が消えたことをたまの生成クラスに知らせる

        }
    }
}

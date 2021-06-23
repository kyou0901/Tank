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
     
            //‚½‚Ü‚ðíœ
            Destroy( gameObject );

            //‹…‚ªÁ‚¦‚½‚±‚Æ‚ð‚½‚Ü‚Ì¶¬ƒNƒ‰ƒX‚É’m‚ç‚¹‚é

        }
    }
}

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
     
            //���܂��폜
            Destroy( gameObject );

            //�������������Ƃ����܂̐����N���X�ɒm�点��

        }
    }
}
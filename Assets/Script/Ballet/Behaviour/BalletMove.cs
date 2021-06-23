using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMove : BalletBehaviour
{
    //たまを撃つ方向
    Vector3 balletDir;
    //たまの速度 //TODO publicを戻して、定数にするのを忘れないように
    private const float balletSpeed = 0.005f;
    private void Start() {
        balletDir = GameObject.Find( "BalletPos" ).transform.forward;
    }
    public override void BalletAction() {
        transform.Translate( balletDir * balletSpeed ) ;
    }
}

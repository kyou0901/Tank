using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTurn : TankBehaviour
{

    //タンクの旋回
    public override void TankAction() {
        //ホリゾンタルキーで旋回
        //TODO　旋回が速いので、うにてぃじゃぱんみる
        float h = Input.GetAxis( "Horizontal" );


        transform.Rotate( 0, h, 0 );
    }
}

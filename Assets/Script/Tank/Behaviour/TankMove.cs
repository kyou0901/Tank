using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : TankBehaviour
{
    //戦車の移動速度
    public float moveSpeed = 0.5f;
    //戦車の旋回速度
    private float trunSpeed;
    //戦車の移動ベクトル
    private Vector3 dir;


    //タンクの移動
    public override void TankAction(  ) {

        //マウスホイールで前進する
      float  mouseScroll = Input.GetAxis( "Mouse ScrollWheel" );

        transform.Translate( 0,0, mouseScroll*moveSpeed );

    }

   
}

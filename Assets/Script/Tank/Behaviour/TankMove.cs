using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : TankBehaviour
{
    //��Ԃ̈ړ����x
    public float moveSpeed = 0.5f;
    //��Ԃ̐��񑬓x
    private float trunSpeed;
    //��Ԃ̈ړ��x�N�g��
    private Vector3 dir;


    //�^���N�̈ړ�
    public override void TankAction(  ) {

        //�}�E�X�z�C�[���őO�i����
      float  mouseScroll = Input.GetAxis( "Mouse ScrollWheel" );

        transform.Translate( 0,0, mouseScroll*moveSpeed );

    }

   
}
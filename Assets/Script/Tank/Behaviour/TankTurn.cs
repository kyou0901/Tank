using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankTurn : TankBehaviour
{

    //�^���N�̐���
    public override void TankAction() {
        //�z���]���^���L�[�Ő���
        //TODO�@���񂪑����̂ŁA���ɂĂ�����ς�݂�
        float h = Input.GetAxis( "Horizontal" );


        transform.Rotate( 0, h, 0 );
    }
}
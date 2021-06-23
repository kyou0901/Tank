using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMove : BalletBehaviour
{
    //���܂�������
    Vector3 balletDir;
    //���܂̑��x //TODO public��߂��āA�萔�ɂ���̂�Y��Ȃ��悤��
    private const float balletSpeed = 0.005f;
    private void Start() {
        balletDir = GameObject.Find( "BalletPos" ).transform.forward;
    }
    public override void BalletAction() {
        transform.Translate( balletDir * balletSpeed ) ;
    }
}
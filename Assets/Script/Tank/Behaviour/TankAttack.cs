using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : TankBehaviour
{
    [SerializeField]
    GameObject balletPrefab;

    //�ʂ̏o���ʒu
    private GameObject balletPos;
    void Start()
    {
        balletPos = GameObject.Find( "BalletPos" );
    }


}
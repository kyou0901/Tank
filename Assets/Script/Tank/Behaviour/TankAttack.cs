using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : TankBehaviour
{
    [SerializeField]
    GameObject balletPrefab;

    //玉の出現位置
    private GameObject balletPos;
    void Start()
    {
        balletPos = GameObject.Find( "BalletPos" );
    }


}

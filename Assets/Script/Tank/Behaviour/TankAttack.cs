using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : TankBehaviour
{
    [SerializeField]
    GameObject balletPrefab;

    //ã ÇÃèoåªà íu
    private GameObject balletPos;
    void Start()
    {
        balletPos = GameObject.Find( "BalletPos" );
    }


}

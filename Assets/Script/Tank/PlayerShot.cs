using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    CreateBallet balletCrate;
    Transform playerBalletPos;
    void Start()
    {
        balletCrate = GameObject.Find( "BalletGenerator" ).GetComponent<CreateBallet>();
        playerBalletPos = transform.Find( "Tank"+gameObject.name+"/Cannon/BalletPos" );

    }

    void Update()
    {
        //////�ʂ̍쐬�E�E�E�ʂ̓����͕ʂ̃X�N���v�g
        if(Input.GetKeyDown(KeyCode.Space)) {
            balletCrate.Create(gameObject.transform, playerBalletPos.position);
        }
    }
}
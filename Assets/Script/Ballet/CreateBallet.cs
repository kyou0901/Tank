using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBallet : MonoBehaviour
{
    GameObject ballet;
    void Start()
    {
        ballet = Resources.Load( "Ballet" ) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Create(Transform parent ,Vector3 balletPos) {
        //引数の場所に生成する
        GameObject cloneBallet;
        cloneBallet = Instantiate( ballet );
        cloneBallet.transform.position = balletPos;
        cloneBallet.transform.SetParent( parent );


    }
}

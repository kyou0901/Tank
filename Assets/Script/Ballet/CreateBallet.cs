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
        //à¯êîÇÃèÍèäÇ…ê∂ê¨Ç∑ÇÈ
        GameObject cloneBallet;
        cloneBallet = Instantiate( ballet );
        cloneBallet.transform.position = balletPos;
        cloneBallet.transform.SetParent( parent );


    }
}

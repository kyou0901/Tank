using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1;
    [SerializeField]
    private float turnSpeed = 0.4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis( "Vertical" );
        float h = Input.GetAxis( "Horizontal" );

        ///////à⁄ìÆ/////////

        if (h == 0) {

            transform.Translate( 0, 0, v * Time.deltaTime * moveSpeed );

        }

        ///////ê˘âÒ/////////

 

        if ( v == 0 ) {
            transform.Rotate( 0, h * turnSpeed, 0 );

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //��Ԃ̈ړ����x
    private float moveSpeed = 0.005f;
    //��Ԃ̐��񑬓x
    private float trunSpeed;
    //��Ԃ̈ړ��x�N�g��
    private Vector3 dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCannon();
        ChangeAngle();
    }

    public void MoveCannon() {
        float h = Input.GetAxis( "Horizontal" );
        float v = Input.GetAxis( "Vertical" );

        dir = new Vector3( v*-1, 0, h );

        transform.Translate( dir * moveSpeed);
    }

    public void ChangeAngle() {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis( "Mouse Y" );


        transform.Rotate( 0, x, 0 );
    }
}
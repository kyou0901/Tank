using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMove : MonoBehaviour
{
    [SerializeField]
    private float balletSpeed = 1.6f;
    Vector3 parentDir;
    void Start()
    {
        //�e�̕������擾�A�i�[���̂��Ƃɐe�q�֌W�����Z�b�g
        parentDir = transform.parent.forward;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( parentDir*balletSpeed*Time.deltaTime );
    }

    private void OnCollisionEnter( Collision collision ) {
        //�^���N�ɓ���������A�����̃G�t�F�N�g���Ă�
        if(collision.transform.tag == "Tank") {
          
            StartCoroutine( collision.gameObject.GetComponent<BreakMotion>().DeadEffectCombo(collision.gameObject) );
         
        }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreatebBallet : TankBehaviour
{
    //���܂̏����̈ʒu
    GameObject balletPos;
    //���܂̃v���n�u
    GameObject prehabFromResource;
    //���ā[���ɑ��݂��邽�܂̂���
    private int totalBallets = 0;
    private void Start() {

        balletPos = GameObject.Find( "BalletPos" );
        prehabFromResource = Resources.Load( "Prefab/Ballet" ) as GameObject;

        Debug.Log( prehabFromResource.name );
    }

    //���𐶐��������鏈��
    public override void TankAction( ) {
        //���N���b�N�ŁA�X�e�[�W�ɂ��܂�5���݂��ĂȂ�������
        if(Input.GetMouseButtonDown(0) && totalBallets != 5  ) {
            //���\�[�X�t�H���_����v���n�u�𐶐�
            GameObject ballet = Instantiate( prehabFromResource );
            //�ʒu�������l�ɃZ�b�g
            ballet.transform.position = balletPos.transform.position;
            //���O������
            ballet.gameObject.name = "Ballet" + this.totalBallets;
            this.totalBallets++;
        } else {
            Debug.Log( "���܂�������" );
        }
    }

    public int GetShotCount() {
        return totalBallets;
    }
}
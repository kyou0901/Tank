using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBallet : MonoBehaviour
{
    //���ʂ̂��܂̃N���X�A1�񂾂����˂ł��āA��x��5���܂ŃX�e�[�W�ɑ��݂ł���
    Ballet ballet;
    void Start()
    {
        ballet = gameObject.AddComponent<Ballet>();
    }

    // Update is called once per frame
    void Update()
    {
        ballet.balletMove.BalletAction();
    }
}
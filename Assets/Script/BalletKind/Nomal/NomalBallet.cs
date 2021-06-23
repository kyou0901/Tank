using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomalBallet : MonoBehaviour
{
    //普通のたまのクラス、1回だけ反射できて、一度に5発までステージに存在できる
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

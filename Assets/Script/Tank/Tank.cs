using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    //タンクのオブジェクトに必要な処理
    public TankMove tankMove;
    public TankAttack tankAtack;
    public TankTurn tankTurn;
    public TankCreatebBallet tankCreateBallet;


    void Start()
    {
        tankMove = gameObject.AddComponent<TankMove>();
        tankAtack = gameObject.AddComponent<TankAttack>();
        tankTurn = gameObject.AddComponent<TankTurn>();
        tankCreateBallet = gameObject.AddComponent<TankCreatebBallet>();
    }

    // Update is called once per frame
    void Update()
    {

    }


}

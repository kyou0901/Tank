using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Tank tank;
  
    void Start()
    {
        tank = gameObject.AddComponent<Tank>();
    }

    
    void Update()
    {
        tank.tankMove.TankAction();
        tank.tankTurn.TankAction();
        tank.tankAtack.TankAction();
        tank.tankCreateBallet.TankAction();
    }
}

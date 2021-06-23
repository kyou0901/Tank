using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballet : MonoBehaviour
{

    public BalletMove balletMove;
    private void Start() {
        balletMove = gameObject.AddComponent<BalletMove>();
    }

}

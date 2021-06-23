using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMove : BalletBehaviour
{
    //‚½‚Ü‚ğŒ‚‚Â•ûŒü
    Vector3 balletDir;
    //‚½‚Ü‚Ì‘¬“x //TODO public‚ğ–ß‚µ‚ÄA’è”‚É‚·‚é‚Ì‚ğ–Y‚ê‚È‚¢‚æ‚¤‚É
    private const float balletSpeed = 0.005f;
    private void Start() {
        balletDir = GameObject.Find( "BalletPos" ).transform.forward;
    }
    public override void BalletAction() {
        transform.Translate( balletDir * balletSpeed ) ;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BreakMotion : MonoBehaviour
{
    ParticleSystem[] deadEffect = new ParticleSystem[3];
    void Start()
    {
        Transform effectparent = transform.parent.Find( "Effect" );
        for (int i =0; i<effectparent.childCount; i++ ) {
            deadEffect[ i ] = effectparent.GetChild( i ).GetComponent<ParticleSystem>();
        } 
    }

    // Update is called once per frame
    void Update()
    {

    }

    //éÄÇÒÇæÇ∆Ç´ÇÃÉRÉãÅ[É`Éì
    public IEnumerator DeadEffectCombo(GameObject deleteObj) {
        Destroy( deleteObj );
        deadEffect[ 0 ].Play();
        yield return new WaitForSeconds( 0.2f );
        deadEffect[ 1 ].Play();
        yield return new WaitForSeconds( 0.2f );
        deadEffect[ 2 ].Play();
        yield return new WaitForSeconds( 0.2f );

    }
}

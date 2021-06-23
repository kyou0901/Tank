using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCreatebBallet : TankBehaviour
{
    //たまの初期の位置
    GameObject balletPos;
    //たまのプレハブ
    GameObject prehabFromResource;
    //すてーじに存在するたまのかず
    private int totalBallets = 0;
    private void Start() {

        balletPos = GameObject.Find( "BalletPos" );
        prehabFromResource = Resources.Load( "Prefab/Ballet" ) as GameObject;

        Debug.Log( prehabFromResource.name );
    }

    //球を生成だけする処理
    public override void TankAction( ) {
        //左クリックで、ステージにたまが5個存在してなかったら
        if(Input.GetMouseButtonDown(0) && totalBallets != 5  ) {
            //リソースフォルダからプレハブを生成
            GameObject ballet = Instantiate( prehabFromResource );
            //位置を初期値にセット
            ballet.transform.position = balletPos.transform.position;
            //名前をつける
            ballet.gameObject.name = "Ballet" + this.totalBallets;
            this.totalBallets++;
        } else {
            Debug.Log( "たまだしすぎ" );
        }
    }

    public int GetShotCount() {
        return totalBallets;
    }
}

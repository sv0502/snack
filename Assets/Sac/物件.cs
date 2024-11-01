using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class 物件 : MonoBehaviour
{
    //讀取遊戲地圖邊界
    public Collider2D 邊界;
    // Start is called before the first frame update
    void Start()
    {
        隨機位置();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)//讀取地圖邊界

    {
        //Debug.Log(collision);

        //Debug.Log(邊界.bounds.min.x);
        //Debug.Log(邊界.bounds.max.x);
        // Debug.Log(邊界.bounds.min.y);
        //Debug.Log(邊界.bounds.max.y);

        // Random.Range(邊界.bounds.min.x, 邊界.bounds.max.x);
        //Random.Range(邊界.bounds.min.y, 邊界.bounds.max.y);

        隨機位置();



    }
    //下面寫法是把程式包起來，要用時直接打void 程式名 () {}就行
    void 隨機位置 () {
        transform.position = new Vector3(
            Random.Range(邊界.bounds.min.x, 邊界.bounds.max.x),
            Random.Range(邊界.bounds.min.y, 邊界.bounds.max.y),
            0);//這是讓物件隨機出現在地圖上的程式
    }

}

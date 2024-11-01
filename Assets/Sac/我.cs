using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 我 : MonoBehaviour
{
    public ui gameUI;
    Vector3 direction;

    public float speed;//設定變數speed，在unity組件裡可以自訂移動速度

    public Transform body;

   public List<Transform> bodies = new List<Transform>();
    void Start()
    {
        Debug.Log(transform.position);

        Time.timeScale = speed;

        bodies.Add(transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && direction != Vector3.down )
        {
            //Debug.Log("W");
            //transform.Translate(Vector3.up);

            direction = Vector3.up; 
        }//如果輸入鍵盤上(w)
        if (Input.GetKeyDown(KeyCode.A) && direction != Vector3.right)
        {
            //Debug.Log("A");
            //transform.Translate(-1, 0, 0);

            direction = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.S) && direction != Vector3.up)
        {
            //Debug.Log("S");
            //transform.Translate(0, -1, 0);

            direction = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.D) && direction != Vector3.left)
        {
            //Debug.Log("D");
           // transform.Translate(1, 0, 0);

            direction = Vector3.right;
        }
        
    }

    private void FixedUpdate()//生命週期
    {
        for (int i = bodies.Count-1; i >0; i--)
        {
            bodies[i].position = bodies[i-1].position;
        }

        transform.Translate(direction );
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("物件"))
        {
            //Instantiate(body);

            bodies.Add(Instantiate(body
                , transform.position
                , Quaternion.identity));
            gameUI.AddScore();
        }
        // Debug.Log(collision);

        if (collision.CompareTag("障礙"))
        {
            Debug.Log("Game Over");
            transform.position = Vector3.zero;
            direction = Vector3.zero;

            for (int i = 1; i < bodies.Count; i++)
            {
                Destroy(bodies[i].gameObject);
               // bodies[i]

            }
            bodies.Clear();
            bodies.Add(transform);

            gameUI.Resetscore();

        }
    }

    
    
        
    
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joschamovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D richard;
    public Vector3 mousepos;
    public Vector3 wichser;
    public int richtung;
    // Start is called before the first frame update
    void Start()
    {
        richard = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        mousepos = new Vector3(wichser.x,wichser.y,0);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y + moveSpeed*Time.deltaTime,0);
            richtung =1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y - moveSpeed*Time.deltaTime,0);
            richtung = 3;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3 (transform.position.x - moveSpeed*Time.deltaTime,transform.position.y,0);
            richtung = 4;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3 (transform.position.x + moveSpeed*Time.deltaTime,transform.position.y,0);
            richtung = 2;
        }
    }
}

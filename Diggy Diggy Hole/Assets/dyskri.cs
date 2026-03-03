using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dyskri : MonoBehaviour
{
    public GameObject explo;
    public Rigidbody2D richard;
    // Start is called before the first frame update
    void Start()
    {
        richard = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        richard.AddForce(transform.up*20);
    }
    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Stone")){
            Instantiate(explo,transform.position,transform.rotation);
            Destroy(this.gameObject);
        }
    }
}

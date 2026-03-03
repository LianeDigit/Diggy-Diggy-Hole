using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exploskript : MonoBehaviour
{
    public dynamight dyna;
    public float weiter;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        weiter =1;
        dyna = GameObject.Find("dynamitmanager").GetComponent<dynamight>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < weiter)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<StoneScript>().currentDamage -= dyna.damage;
    }
    
}

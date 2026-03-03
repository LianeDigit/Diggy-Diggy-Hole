using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hackclub : MonoBehaviour
{
    public hackernisator sator;
    public GameObject player;
    public GameObject wasistdas;
    public bool hit;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Josha");
        sator = GameObject.Find("Hackclub").GetComponent<hackernisator>();
        hit = true;
    }
    void Update()
    {
        transform.RotateAround(player.transform.position, Vector3.forward, sator.rotatetime * Time.deltaTime);
    }
    public void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject != wasistdas){
            collision.gameObject.GetComponent<StoneScript>().currentDamage -= sator.damage;
            wasistdas = collision.gameObject;
        }
    }
}

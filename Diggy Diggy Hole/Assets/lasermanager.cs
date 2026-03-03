using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lasermanager : MonoBehaviour
{
    public GameObject laser;
    public float damage;
    public GameObject josha;
    // Start is called before the first frame update
    void Start()
    {
        josha = GameObject.Find("Josha");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            
        }
    }
}

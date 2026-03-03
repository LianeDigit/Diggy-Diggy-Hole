using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamight : MonoBehaviour
{
    public float damage;
    public GameObject dynamite;
    public Transform rot;
    public joschamovement fickdich;
    public float timer;
    public float weiter;
    public int kann;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kann ==1 && timer < weiter)
        {
            timer = timer+ Time.deltaTime;
        }
        else
        {
            kann = 2;
            timer = 0;
        }
        if (fickdich.richtung == 1)
        {
            rot.rotation = Quaternion.Euler(0,0,0);
        }
        if (fickdich.richtung == 2)
        {
            rot.rotation = Quaternion.Euler(0,0,-90);
        }
        if (fickdich.richtung == 3)
        {
            rot.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (fickdich.richtung == 4)
        {
            rot.rotation = Quaternion.Euler(0,0,90);
        }
        if (Input.GetKeyDown(KeyCode.Space) && kann == 2)
        {
            Instantiate(dynamite,transform.position, rot.rotation);
            kann = 1;
        }
    }
}

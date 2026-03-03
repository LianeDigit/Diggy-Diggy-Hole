using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managbor : MonoBehaviour
{
    public float damage;
    public GameObject[] borer = new GameObject[4];
    public joschamovement fickdich;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fickdich.richtung == 1)
        {
            borer[0].SetActive(true);
            borer[1].SetActive(false);
            borer[2].SetActive(false);
            borer[3].SetActive(false);
        }
        if (fickdich.richtung == 2)
        {
            borer[0].SetActive(false);
            borer[1].SetActive(true);
            borer[2].SetActive(false);
            borer[3].SetActive(false);
        }
        if (fickdich.richtung == 3)
        {
            borer[0].SetActive(false);
            borer[1].SetActive(false);
            borer[2].SetActive(true);
            borer[3].SetActive(false);
        }
        if (fickdich.richtung == 4)
        {
            borer[0].SetActive(false);
            borer[1].SetActive(false);
            borer[2].SetActive(false);
            borer[3].SetActive(true);
        }
    }
}

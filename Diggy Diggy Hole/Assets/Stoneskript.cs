using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StoneScript : MonoBehaviour
{
    public float maxDamage;
    public float currentDamage;
    public float gold;
    public int value;
    public player joshi;
    // Start is called before the first frame update
    void Start()
    {
        maxDamage = Random.Range(100,500);
        joshi = GameObject.Find("Josha").GetComponent<player>();
        gold = maxDamage;
        currentDamage = maxDamage;
        Debug.Log("guckhier"+ maxDamage);
        this.transform.localScale = new Vector3(3, 3, 3);
        Debug.Log("guckma"+maxDamage);
    }

    // Update is called once per frame
    void Update()
    { 
        if (currentDamage<=0)
        {
            joshi.gold = joshi.gold + gold * value;
            Debug.Log(joshi.gold+ "fickdeineMudda" + gold);
            Destroy(this.gameObject);
        }
        if (currentDamage>30){
            transform.localScale = new Vector3(currentDamage/maxDamage*maxDamage/100, currentDamage/maxDamage*maxDamage/100, currentDamage/maxDamage*maxDamage/100);
        }

    }
    
}

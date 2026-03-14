using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borskript : MonoBehaviour
{
    public managbor deineMudda;
    // Start is called before the first frame update
    void Start()
    {
        deineMudda = this.transform.parent.gameObject.GetComponent<managbor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        
        
        collision.transform.gameObject.GetComponent<StoneScript>().currentDamage -= deineMudda.damage * Time.deltaTime;
        
        
    }
}

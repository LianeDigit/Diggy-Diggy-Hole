using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class horsti : MonoBehaviour
{
    public GameObject picksymb;
    public GameObject dynsymb;
    public GameObject hacke;
    public GameObject youwon;
    public player player;
    public managbor borer;
    public int borerupgrades;
    public hackernisator sator;
    public int hackgrades;
    public dynamight dyns;
    public int dynagrades;
    public float preis;
    public GameObject händlerkärtchen;
    public TMP_Text preistext;
    public TMP_Text borecounter;
    public TMP_Text dyncounter;
    public TMP_Text axecounter;
    public bool active;
    // Start is called before the first frame update
    void Start()
    {
        preis = 200;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active == true){
            preistext.text = preis.ToString();
        }
        borecounter.text = borerupgrades.ToString();
        dyncounter.text = dynagrades.ToString();
        axecounter.text = hackgrades.ToString();
        if (borerupgrades ==5 && hackgrades == 5 && dynagrades == 5)
        {
            youwon.SetActive(true);
        }
    }
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            händlerkärtchen.SetActive(true);
            active = true;
        }
    }
    public void close()
    {
        händlerkärtchen.SetActive(false);
        active = false;
    }
    public void upgradebohrer()
    {
        if (player.gold > preis && borerupgrades < 5)
        {
            player.gold -= preis;
            borerupgrades += 1;
            borer.damage = borer.damage*1.5f;
            preis = Mathf.RoundToInt(preis * 1.25f);
        }
    }
    public void hackergrade()
    {
        if (player.gold > preis && hackgrades < 5)
        {
            Instantiate(hacke, sator.gameObject.transform.position, sator.gameObject.transform.rotation, sator.gameObject.transform.parent);
            player.gold -= preis;
            hackgrades += 1;
            sator.damage = sator.damage * 1.25f;
            sator.rotatetime = sator.rotatetime * 1.25f;
            preis = Mathf.RoundToInt(preis* 1.25f);
            picksymb.SetActive(true);
        }
    }
    public void dynagrade()
    {
        
        if(player.gold > preis && dynagrades < 5)
        {
            dyns.darf = true;
            player.gold -= preis;
            dynagrades += 1;
            dyns.damage = dyns.damage * 1.5f;
            dyns.weiter -= 1;
            preis = Mathf.RoundToInt(preis * 1.25f);
            dynsymb.SetActive(true);
        }
    }
    
}

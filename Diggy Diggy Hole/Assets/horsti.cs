using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class horsti : MonoBehaviour
{
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
            borecounter.text = borerupgrades.ToString();
            dyncounter.text = dynagrades.ToString();
            axecounter.text = hackgrades.ToString();
        }
        if (borerupgrades ==3 && hackgrades == 3 && dynagrades == 3)
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
        if (player.gold > preis && borerupgrades < 3)
        {
            player.gold -= preis;
            borerupgrades += 1;
            borer.damage = borer.damage*1.5f;
            preis = preis * 1.25f;
        }
    }
    public void hackergrade()
    {
        if (player.gold > preis && hackgrades < 3)
        {
            player.gold -= preis;
            hackgrades += 1;
            sator.damage = sator.damage * 1.25f;
            sator.rotatetime = sator.rotatetime * 1.25f;
            preis = preis* 1.25f;
        }
    }
    public void dynagrade()
    {
        if(player.gold > preis && dynagrades < 3)
        {
            player.gold -= preis;
            dynagrades += 1;
            dyns.damage = dyns.damage * 1.5f;
            dyns.weiter -= 1;
            preis = preis * 1.25f;
        }
    }
}

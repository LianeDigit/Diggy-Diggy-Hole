using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int a;
    public int counter;
    public int x1;
    public int x2;
    public int x3;
    public int y1;
    public int y2;
    public int y3;
    public GameObject Stein1;
    public GameObject Stein2;
    public GameObject Stein3;
    public bool YoMom1=false;
    public bool YoMom2=false;
    
    // Start is called before the first frame update
    void Start()
    {
           for(int x=0; x<a; x++)
           {
               while(YoMom1==false) {
                   x1=Random.Range(-134,148);
                   y1=Random.Range(-111,113);
                   if (x1<-92||y1<-46||x1>65||y1>41) {
                       //if() {
                           Instantiate(Stein1, new Vector3(x1,y1,0),transform.rotation);
                           YoMom1=true;
                       //}
                   }
               }
               YoMom1=false;
               if(counter%2==0) {
                   while(YoMom2==false) {
                       x2=Random.Range(-92,65);
                       y2=Random.Range(-46,41);
                       if (x2<-48||y2<-30||x2>33||y2>23) {
                           //if() {
                               Instantiate(Stein2, new Vector3(x2,y2,0),transform.rotation);
                               YoMom2=true;
                           //}
                       }
                   }
                   YoMom2=false;
               }
               if(counter%3==0) {
                x3=Random.Range(-48,33);
                y3=Random.Range(-30,23);
                if(x3<-10||y3<0||x3>7||y3>7) {
                   Instantiate(Stein3, new Vector3(x3,y3,0),transform.rotation);
               }
               }
               ++counter;
           }
               
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}



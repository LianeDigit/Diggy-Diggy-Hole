using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bohrer : MonoBehaviour
{
    [SerializeField] private Transform aimTransform;
    [SerializeField] public float damage = 10f;  // WICHTIG: Wert gesetzt!
    public Vector3 mousePosition;
    public Rigidbody2D richardomardo;  // Für Physik-Bewegung später?
    
    void Update()
    {
        // Maus-Position korrekt holen
        Vector3 mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = 10f;  // Besser als 0f
        
        mousePosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);

        // Richtung zum Mauszeiger
        Vector3 aimDirection = (mousePosition - aimTransform.position).normalized;
        
        // Winkel berechnen (-90f für Sprite der nach oben zeigt)
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(0, 0, angle);  // Sauberer mit Quaternion
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger Enter: " + collision.name);  // Debug für alle Objekte
        
        // Schaden für Stein-Objekte
        StoneScript stone = collision.GetComponent<StoneScript>();
        if (stone != null)
        {
            Debug.Log("Schaden an Stein: " + damage);
            stone.currentDamage += damage;
        }
    }
    
    // FÜR DAUERHAFTEN SCHADEN (während Bohrer im Stein steckt):
    private void OnTriggerStay2D(Collider2D collision)
    {
        StoneScript stone = collision.GetComponent<StoneScript>();
        if (stone != null)
        {
            stone.currentDamage += damage * Time.deltaTime;
        }
    }
}
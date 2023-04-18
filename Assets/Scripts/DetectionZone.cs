using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    public List<Collider2D> detectedColliders = new List<Collider2D>();
    Collider2D col;

    void Awake()
    {
        col = GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        detectedColliders.Add(collider);
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        detectedColliders.Remove(collider);
    }
}

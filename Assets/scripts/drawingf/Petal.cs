using UnityEngine;

public class petal : MonoBehaviour
{
    // --- declare variables ---
    public Transform flowerPosition;
    public float flowerSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // --- start at flower's position ---
        transform.position = flowerPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        // --- increment position ---
        transform.position -= transform.up * flowerSpeed * Time.deltaTime;

        // --- check for reset ---
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y < 0)
        {// --- offscreen --- 
            // --- reset back to flower's position ---
            transform.position = flowerPosition.position;
        }

    }
}

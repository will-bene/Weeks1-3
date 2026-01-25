using UnityEngine;

public class petal : MonoBehaviour
{
    // --- declare variables ---
    public Transform flowerPosition;
    public float petalStartSpeed;
    public float petalSpeed;
    public float petalGravity;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // --- start at flower's position ---
        transform.position = flowerPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        // --- inrement gravity ---
        petalSpeed += petalGravity * Time.deltaTime;

        // --- increment position ---
        transform.position -= transform.up * petalSpeed * Time.deltaTime;

        // --- check for reset ---
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y < 0)
        {// --- offscreen --- 
            // --- reset back to flower's position, reset speed ---
            transform.position = flowerPosition.position;
            petalSpeed = petalStartSpeed;
        }

    }
}

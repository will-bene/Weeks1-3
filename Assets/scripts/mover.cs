using Unity.VisualScripting;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 0.01f;
    int curDir = 1;
    float speedMax = 0.2f;
    public float xMax = 100;
    public float xMin = -100;
    float acc = 0.01f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed*curDir;
        if (newPosition.x > xMax || newPosition.x < xMin)
        {
            if (speed <= speedMax)
            { 
                speed += acc;
            }
                curDir *= -1;
        }
        transform.position = newPosition;
    }
}

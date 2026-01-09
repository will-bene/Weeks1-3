using Unity.VisualScripting;
using UnityEngine;

public class mover : MonoBehaviour
{
    public Camera gameCamera;
    public float hspeed = 0.01f;
    public float vspeed = 0f;
    int curDir = 1;
    float speedMax = 0.2f;

    float acc = 0.01f;

    float scrWid = Screen.width;
    float scrHgt = Screen.height;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
 
        Vector3 newPosition = transform.position;
        newPosition.x += hspeed * curDir;
        newPosition.y += vspeed * curDir;
        Vector3 worldPosition = gameCamera.WorldToScreenPoint(newPosition);
       
        if (worldPosition.x > scrWid || worldPosition.x < 0)
        {
            if (hspeed <= speedMax)
            { 
                hspeed += acc;
            }
                curDir *= -1;
        }

        if (worldPosition.y > scrHgt || worldPosition.y < 0)
        {
            if (vspeed <= speedMax)
            {
                vspeed += acc;
            }
            curDir *= -1;
        }
        transform.position = newPosition;
    }
}

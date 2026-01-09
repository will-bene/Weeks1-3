using UnityEngine;
using UnityEngine.InputSystem;


public class mouseFollow : MonoBehaviour
{


    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        Vector3 worldMousePos = gameCamera.ScreenToWorldPoint(mousePos);
        worldMousePos.z = 0;
        transform.position = worldMousePos;

 
        //gameCamera.WorldToScreenPoint();

    }
}

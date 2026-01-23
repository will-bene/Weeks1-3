using UnityEngine;
using UnityEngine.InputSystem;

public class Looker : MonoBehaviour
{
    public float rotationSpeed;
    public float ZMax;
    public float ZMin;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotating in a direction and swapping

        //if (transform.eulerAngles.z > ZMax || transform.eulerAngles.z < ZMin)
        //{
        //    rotationSpeed *= -1;
        //}
        ////If we wanted to move the object, we would use transform.position
        //Vector3 currentRotation = transform.eulerAngles;
        //currentRotation.z += rotationSpeed * Time.deltaTime;

        //transform.eulerAngles = currentRotation;


        //Debug.Log(transform.eulerAngles);

       Vector3 currentMousePosition = Mouse.current.position.ReadValue();
       Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition);
       worldMousePosition.z = 0;

       //setting the direction we're looking in, to get direction you get end-start
       transform.up = worldMousePosition-transform.position;

         

       transform.position += transform.up * 1f * Time.deltaTime;



    }
}


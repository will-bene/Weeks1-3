using System.Security.Cryptography;
using UnityEngine;
using static UnityEditor.Rendering.CameraUI;

public class bee : MonoBehaviour
{
    // --- declare variables ---
    public float orbitSpeed = 30;
    public float orbitRotation = 0;
    public float orbitLength = 3;
    public Transform flowerPosition;

    public AnimationCurve animationCurve;
    public float animationSpeed; 
    public float animHeight=3;
    public float animProgress = 0;

    public float imageXScale = 1;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //--- orbit ---
        //update orbit
        orbitRotation += orbitSpeed * Time.deltaTime;

        //wrap orbit direction back around
        if (orbitRotation > (Mathf.PI*2))
        {//greater than max radius, reset
            orbitRotation = 0;
        }

        //get flower position
        Vector3 newPosition = flowerPosition.position;
        //get a distance the current orbit's angle away and change new position to reflect
        newPosition.x += orbitLength * Mathf.Cos(orbitRotation);
        newPosition.y += orbitLength * Mathf.Sin(orbitRotation);

        //--- animation curve ---
        //incrememnt floatinganimation progress
        animProgress += animationSpeed*Time.deltaTime;
        //loop animation
        if (animProgress >= 1)
        { animProgress = 0; }
        //set y offset based on curve progress
        newPosition.y-= animHeight * animationCurve.Evaluate(animProgress);





        //--- change x scale (image mirroring) when angle calls for it
        if (orbitRotation > Mathf.PI)
        {//more than halfway through radius, flip scale
            imageXScale = -1;
        }
        else
        {//back to beginning, reset to default scale
            imageXScale = 1;
        }

        //--- set scale ---
        Vector3 newScale = transform.localScale;
        newScale.x = imageXScale;
        transform.localScale = newScale;

        //--- set position ---
        transform.position = newPosition;

    }
}

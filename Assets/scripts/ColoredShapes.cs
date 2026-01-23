using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColoredShapes : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color color = Color.white;
    public float colorTimer=0;
    public float colorTimerMax;
    public List<SpriteRenderer> spriteRenderers;
    public int imageIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorTimer-=Time.deltaTime;
        if (colorTimer <= 0)
        {
            color = Random.ColorHSV();
            colorTimer = colorTimerMax;
            spriteRenderer.color = color;
        }

        spriteRenderer.sprite = spriteRenderers[imageIndex].sprite;
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            imageIndex++;
            if (imageIndex>=spriteRenderers.Count)
            {
                imageIndex = 0;
            }
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    // Unterschied Awake zu Start?
    // Warum das f an den floats dran?
    // was ist ein Vector3? warum die 3?



    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteindex;

    private void Awake() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            
            direction = Vector3.up * strength;
        }

        //direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;

    }

    private void AnimateSprite()
    {
        spriteindex++;

        if (spriteindex >= sprites.Length)
        {
            spriteindex = 0;
        }

        spriteRenderer.sprite = sprites[spriteindex];
    }



}

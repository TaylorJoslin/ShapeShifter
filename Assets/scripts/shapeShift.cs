using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeShift : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    public Sprite[] sprites;
    private int current = 0;


    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (sprites.Length > 0 )
        {
            sr.sprite = sprites[current];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            current = (current + 1) % sprites.Length;
            sr.sprite = sprites[current];
        } 
    }
}

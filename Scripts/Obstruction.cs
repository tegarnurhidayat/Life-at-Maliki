using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstruction : MonoBehaviour
{
    public SpriteRenderer TheSpriteRenderer { get; set; }
    private Color defaultColor;
    private Color fadedColor;

    // Start is called before the first frame update
    void Start()
    {
        TheSpriteRenderer = GetComponent<SpriteRenderer>();
        defaultColor = TheSpriteRenderer.color;
        fadedColor = defaultColor;
        fadedColor.a = 0.5f;
    }

    public void FadeOut()
    {
        TheSpriteRenderer.color = fadedColor;
    }

    public void FadeIn()
    {
        TheSpriteRenderer.color = defaultColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

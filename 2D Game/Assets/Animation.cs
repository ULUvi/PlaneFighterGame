using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Animation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
     
    public Sprite Frame1;
    public Sprite Frame2;
    public Sprite Frame3;
    public Sprite Frame4;
    public int i;
    // Start is called before the first frame update
    void ChangeSprite()
    {
        if (spriteRenderer.sprite == Frame1)
        { spriteRenderer.sprite = Frame2; }
        else if (spriteRenderer.sprite == Frame2)
        { spriteRenderer.sprite = Frame3; }
        else if (spriteRenderer.sprite == Frame3)
        { spriteRenderer.sprite = Frame4; }
        else if (spriteRenderer.sprite == Frame4)
        { spriteRenderer.sprite = Frame1; }
    }
    void SetSprite() {
        spriteRenderer.sprite = Frame1;
    }
    void Start()
    {
        i = 0;
        SetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (i==0)
        {
            ChangeSprite();
            i = 0;
        }
        else
            i++;
    }
   
}

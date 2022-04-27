using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtiAnimation : MonoBehaviour
{public SpriteRenderer spriteRenderer;
    public Sprite Frame1;
public Sprite Frame2;
public Sprite Frame3;
public Sprite Frame4;
public Sprite Frame5;
public Sprite Frame6;
public Sprite Frame7;
public Sprite Frame8;
public Sprite Frame9;
public int i;
    public bool answer;

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
    { spriteRenderer.sprite = Frame5; }
    else if (spriteRenderer.sprite == Frame5)
    { spriteRenderer.sprite = Frame6; }
    else if (spriteRenderer.sprite == Frame6)
    { spriteRenderer.sprite = Frame7; }
    else if (spriteRenderer.sprite == Frame7)
    { spriteRenderer.sprite = Frame8; }
    else if (spriteRenderer.sprite == Frame8)
    { spriteRenderer.sprite = Frame9; }
    else if (spriteRenderer.sprite == Frame9)
    { spriteRenderer.sprite = Frame1;
            answer = false;}
}
void SetSprite()
{
    spriteRenderer.sprite = Frame1;
}
void Start()
{
     i = 0;
    SetSprite();
}
 void Update()
    {
        Randomizer();
        if (answer == true)
        {
            if (i == 20)
            {
                i = 0;
                ChangeSprite();
            }
            else
                i++;
        }   
    }

    bool Randomizer()
    {
       int x = (int)Random.Range(0f, 60f);
        if(x==3)
        { answer=true; }
        return answer;
    }

}

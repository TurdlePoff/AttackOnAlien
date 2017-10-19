//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ButtonSwitch : MonoBehaviour {
//    public Sprite rButtonOff; // Drag your first sprite here
//    public Sprite rButtonOn; // Drag your second sprite here

//    private SpriteRenderer spriteRenderer;

//    // Use this for initialization
//    void Start () {
//        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
//        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
//            spriteRenderer.sprite = rButtonOn; // set the sprite to sprite1
//    }

//    // Update is called once per frame
//    void Update () {
//        //if (GameObject.Find("Pistol").GetComponent<Weapon>()) //will check if true
//        if (Input.GetKeyDown(KeyCode.Space)) // If the space bar is pushed down
//        {
//            ChangeSprite(); // call method to change sprite
//        }
//    }

//    void ChangeSprite()
//    {
//        if (spriteRenderer.sprite == rButtonOff) // if the spriteRenderer sprite = sprite1 then change to sprite2
//        {
//            spriteRenderer.sprite = rButtonOn;
//        }
//        else
//        {
//            spriteRenderer.sprite = rButtonOff; // otherwise change it back to sprite1
//        }
//    }
//}


////public Sprite sprite1; // Drag your first sprite here
////public Sprite sprite2; // Drag your second sprite here

////private SpriteRenderer spriteRenderer;

////void Start()
////{
////    spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
////    if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
////        spriteRenderer.sprite = sprite1; // set the sprite to sprite1
////}

////void Update()
////{
////    
////}
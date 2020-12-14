using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ImageLoader
{
    public static Sprite SomeImage => Resources.Load<Sprite>("Sprites/UI/some_image");
}
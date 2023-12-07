using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Orion
{


    public class OImage : OAttributeObject
    {
        [SerializeField]
        Image AttributeImage;
        [SerializeField]
        RectTransform Image_Transform;
        public void UpdateOImage(int width, int height, Sprite image)
        {
            AttributeImage.sprite = image;
            Image_Transform.sizeDelta = new Vector2(width, height);
            

        }
    }
}
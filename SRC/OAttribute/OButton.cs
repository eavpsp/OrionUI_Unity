using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace Orion
{

    public class OButton : OAttributeObject
    {
        [SerializeField]
        TMP_Text buttonText;
        [SerializeField]
        Button buttonObject;
        [SerializeField]
        Image buttonImage;
        [SerializeField]
        RectTransform buttonRectTransform;

        public void SetButtonData(string buttonText, int width, int height, UnityEvent actionToInvoke, Sprite buttonImage = null)
        {
            this.buttonText.text = buttonText;
            if (buttonImage != null)
            {
                this.buttonImage.sprite = buttonImage;
            }
            buttonObject.onClick.AddListener(actionToInvoke.Invoke);
            buttonRectTransform.sizeDelta = new Vector2(width, height);
        }
    }
}

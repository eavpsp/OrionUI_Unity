using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace Orion
{
    
    public class OString : OAttributeObject
    {
        [SerializeField]
        TMP_InputField StringUI;

        public void Build(string stringText, Color color, float fontSizeMin = 18, float fontSizeMax = 36, TMP_FontAsset font = null)
        {
      
            if (color == null)
            {
                color = Color.white;
            }
            StringUI.textComponent.fontSizeMin = fontSizeMin;
            if (font != null)
            {
                StringUI.textComponent.font = font;

            }
            StringUI.textComponent.fontSizeMax = fontSizeMax;
            StringUI.textComponent.fontSize = fontSizeMin;
            StringUI.textComponent.color = color;
            StringUI.text = stringText;
        }

    }
}
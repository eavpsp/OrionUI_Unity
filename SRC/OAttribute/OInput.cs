using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Orion

{


    public class OInput : OAttributeObject
    {
        [SerializeField]
        TextMeshProUGUI attributeTitle;
        [SerializeField]
        TMP_InputField textInput;

        public string GetInput()
        {
            return textInput.text;
        }
        public void SetAttributeData(string title, string placeHolder)
        {
            attributeTitle.text = title;
            textInput.text = placeHolder;
        }
    }

}
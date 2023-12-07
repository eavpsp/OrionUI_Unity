using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Orion
{


    public class OVector : OAttributeObject
    {
        [SerializeField]
        TMP_InputField inputObject;
        [SerializeField]
        TextMeshProUGUI attributeTitle;
        [SerializeField]
        Transform contentView;
        List<TMP_InputField> inputObjects = new List<TMP_InputField>();
        string sepearator;
        public void SetVectorAttribute(string[] values, string seperator,  string objectName)
        {
            foreach (string value in values)
            {
                TMP_InputField newField = Instantiate(inputObject, contentView);
                newField.textComponent.text = value;
                inputObjects.Add(newField);
            }
            this.sepearator = seperator;
            attributeTitle.text = objectName;
        }
        public string GetData()
        {
            string data = "";
            foreach (TMP_InputField fields in inputObjects)
            {
                data += fields.textComponent.text + sepearator;
            }
            return data;
        }
        
    }
}

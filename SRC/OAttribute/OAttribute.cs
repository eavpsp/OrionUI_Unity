using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
namespace Orion
{
    public class OAttributeObject : MonoBehaviour
    { }
   
    public class OAttribute : MonoBehaviour
    {
        [SerializeField]
        OAttributeObject  vectorObject, inputObject, sliderObject, buttonObject,imageObject, stringObject;
        [SerializeField]
        TMP_FontAsset font;
        public static OAttribute Handler;
        public static OAttributeObject BuildAttributeText(string stringText, Color color, float fontSizeMin = 18, float fontSizeMax = 36)
        {
            OAttributeObject newStringAttribute = GameObject.Instantiate(Handler.stringObject);
            OString stringData = newStringAttribute.GetComponent<OString>();
            stringData.Build(stringText, color, fontSizeMin, fontSizeMax, Handler.font);
            return newStringAttribute;
        }
        public static OAttributeObject BuildAttributeVector(string[] values, string title, string seperator)
        {
            OAttributeObject newVectorObject = GameObject.Instantiate(Handler.vectorObject);
            OVector vectorData = newVectorObject.GetComponent<OVector>();
            vectorData.SetVectorAttribute(values, seperator, title);
            return newVectorObject;

        }
        public static OAttributeObject BuildAttributeInputField(string placeholderText, string title)
        {
            OAttributeObject newInputObject = GameObject.Instantiate(Handler.inputObject);
            OInput inputData = newInputObject.GetComponent<OInput>();
            inputData.SetAttributeData(title, placeholderText);
            return newInputObject;

        }
        public static OAttributeObject BuildAttributeButton(string buttonText, int width, int height, UnityEvent eventToInvoke, Sprite buttonImage = null)
        {
            OAttributeObject newButtonObject = GameObject.Instantiate(Handler.buttonObject);
            OButton buttonData = newButtonObject.GetComponent<OButton>();
            buttonData.SetButtonData(buttonText, width, height, eventToInvoke, buttonImage);
            return newButtonObject;

        }
        public static OAttributeObject BuildAttributeImage(Sprite image, int width, int height)
        {
            OAttributeObject newImageObject = GameObject.Instantiate(Handler.imageObject);
            OImage imageData = newImageObject.GetComponent<OImage>();
            imageData.UpdateOImage(width, height, image);
            return newImageObject;

        }
        public static OAttributeObject BuildAttributeSlider(float min, float max, float current, string title)
        {

            OAttributeObject newSliderObject = GameObject.Instantiate(Handler.inputObject);
            OSlider sliderData = newSliderObject.GetComponent<OSlider>();
            sliderData.SetOSlider(min, max, current, title);
            return newSliderObject;

        }

        void Awake()
        {
            Handler = this;
        }
        
        
    }
    
}
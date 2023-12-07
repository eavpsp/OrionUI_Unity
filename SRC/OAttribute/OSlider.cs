using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Orion

{


    public class OSlider : OAttributeObject
    {
        [SerializeField]
        TextMeshProUGUI attributeTitle, attributeValue;
        [SerializeField]
        Slider sliderComponent;

        public void SetOSlider(float min, float max, float current, string title)
        {
            sliderComponent.minValue = min;
            sliderComponent.maxValue = max;
            sliderComponent.value = current;
            attributeTitle.text = title;
            attributeValue.text = current.ToString();
        }

        public void UpdateValue(float value)
        {
            attributeValue.text = value.ToString();

        }
    }
}
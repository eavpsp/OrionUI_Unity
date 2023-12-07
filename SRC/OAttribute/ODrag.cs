using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Orion
{
    public class ODrag : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            CustomCursor.SetDrag();
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            CustomCursor.SetDefault();

        }


    }
}

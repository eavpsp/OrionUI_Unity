using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Orion
{
    public class OInteract : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            CustomCursor.SetInteract();
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            CustomCursor.SetDefault();

        }


    }
}

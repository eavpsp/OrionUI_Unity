using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Orion
{
    public class OEdit : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        public void OnPointerEnter(PointerEventData eventData)
        {
            CustomCursor.SetEdit();
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            CustomCursor.SetDefault();

        }


    }
}
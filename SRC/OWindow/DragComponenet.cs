using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Orion
{


    public class DragComponenet : MonoBehaviour, IDragHandler, IEndDragHandler, IPointerDownHandler
    {
        [SerializeField]
        private Canvas canvas;
        [SerializeField]
        private RectTransform dragTransform;
        bool init = false;
        public void Init(Canvas can)
        {
            canvas = can;
            init = true;
        }
        public void OnDrag(PointerEventData eventData)
        {
            if (canvas == null)
            {
                return;
            }
            dragTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
            CustomCursor.SetMove();
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            CustomCursor.SetDefault();

        }
        public void OnPointerDown(PointerEventData eventData)
        {
            dragTransform.SetAsLastSibling();
        }
    }
}
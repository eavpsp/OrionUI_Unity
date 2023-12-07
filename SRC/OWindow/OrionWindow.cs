using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace Orion
{
    [System.Serializable]
    public class OrionWindow : MonoBehaviour
    {
        [SerializeField]
        private Transform contentView;
        private List<UnityEvent> elipseMenuActions = new List<UnityEvent>();
        [SerializeField]
        private ContextMenu elipseMenu;
        private float windowWidth;
        private float windowHeight;
        [SerializeField]
        private RectTransform windowRect;
        [SerializeField]
        TextMeshProUGUI headerText;
        [SerializeField]
        DragComponenet dragHandler;
        [SerializeField]
        GameObject contentViewObject;
        //TODO: GRID and (Done) TABLE views
        public void SetWindowData(string headerText, OAttributeObject[] content = null, UnityEvent[] elipseMenu = null)
        {
            
            this.headerText.text = headerText;
            foreach (OAttributeObject objectData in content)
            {
                AddContent(objectData);
            }
            //create buttons for elipse menu
            //add content to contentview

        }
        public void SetPosition(Vector2 pos)
        {
            windowRect.anchoredPosition = pos;
        }
        public void SetDragCanvas(Canvas can)
        {
            if (dragHandler != null)
            {
                dragHandler.Init(can);

            }
            else
            {
                dragHandler = GetComponent<DragComponenet>();
                dragHandler.Init(can);
            }
        }
        public void AddContent(OAttributeObject objectToAdd)
        {
           objectToAdd.transform.parent =  contentView;

        }
        public void AddEvent(UnityEvent elipseEvent)
        {
            elipseMenuActions.Add(elipseEvent);
        }
        public void OpenElipseMenu()
        {
            //check if menu will be off screen
        }
        public void Minimize()
        {
            contentViewObject.SetActive(!contentViewObject.activeSelf);
        }
        public void CloseWindow()
        {
            this.gameObject.SetActive(false);
        }
        void AddDefaultElipseActions() 
        { 
            //close window
            //minimize window
        }
        

    }
}


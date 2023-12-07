using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class OWindow : MonoBehaviour
    {
        public enum WindowSize { small, medium, large};
        [SerializeField]
        OrionWindow windowSmall, windowMed, windowLarge;
        static OrionWindow WINDOW_SMALL, WINDOW_MEDIUM, WINDOW_LARGE;

        private void Awake()
        {
            WINDOW_SMALL = windowSmall;
            WINDOW_LARGE = windowLarge;
            WINDOW_MEDIUM = windowMed;
        }
        public static OrionWindow CreateWindow(WindowSize size = WindowSize.small)
        {
            //Find Canvas
            OrionWindow windowObject = null;
            switch (size) 
            {
                case WindowSize.small:
                windowObject = WINDOW_SMALL;
                break;
                case WindowSize.medium:
                windowObject = WINDOW_MEDIUM;
                break;
                default:
                windowObject = WINDOW_LARGE;
                break;
            }

            Canvas windowCanvas = FindObjectOfType<Canvas>();
            if (windowCanvas != null)
            {
                OrionWindow window = Instantiate(windowObject);
                window.SetPosition(new Vector2(960, 540));
                window.gameObject.transform.parent = windowCanvas.transform;
                window.SetDragCanvas(windowCanvas);
                return window;
            }
            else
            {
                Debug.LogError("No Canvas is in the scene");
                return null;
            }

        }
    }
}
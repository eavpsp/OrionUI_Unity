using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Orion
{
    public class CustomCursor : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField]
        public Texture2D defaultCursor, moveWindow, interactItem, dragItem, textEdit;

        public static CustomCursor instance;
        static void SetCurrentCursor(Texture2D cursorToSet)
        {
            Cursor.SetCursor(cursorToSet, Vector2.zero, CursorMode.Auto);
        }

        public static void SetDefault()
        {
            SetCurrentCursor(instance.defaultCursor);
        }
        public static void SetInteract()
        {
            SetCurrentCursor(instance.interactItem);
        }
        public static void SetDrag()
        {
            SetCurrentCursor(instance.dragItem);
        }
        public static void SetMove()
        {
            SetCurrentCursor(instance.moveWindow);
        }
        public static void SetEdit()
        {
            SetCurrentCursor(instance.textEdit);
        }
        void Awake()
        {
            
            if (instance != null && instance != this)
            {
                Destroy(this);
            }
            else
            {
                instance = this;
                SetCurrentCursor(defaultCursor);
                DontDestroyOnLoad(gameObject);
            }
            

        }



    }
}
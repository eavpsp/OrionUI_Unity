// Shows Examples on how to create windows & add data in Orion UI.
// 
// Only Table View current
//
//

using Orion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MyTestScene : MonoBehaviour
{

    [SerializeField]
    List<Sprite> testImages = new List<Sprite>();
    int currentImage = 0;
    Sprite currentSprite;
    OImage imageInWindow;
    int buttonWidth, buttonHeight;
    int imageWidth = 400;
    int imageHeight = 400;
    void Start()
    {
        BuildTextWindow();
        BuildInputWindow();
        BuildDataWindow();
    }
    void BuildTextWindow()
    {
        string testText = "This Window is only displaying text";
        OAttributeObject testTextAtrribute = OAttribute.BuildAttributeText(testText, Color.white);
        OAttributeObject[] Content = new OAttributeObject[1];
        Content[0] = testTextAtrribute;
        OrionWindow window = OWindow.CreateWindow(OWindow.WindowSize.large);
        string header = "Text Only Window";
        window.SetWindowData(header, Content);
    }
    void BuildInputWindow()
    {
        string inputText = "Sample Input Text...";
        string contentTitle = "Test Input Object";
        OAttributeObject inputTextAttribute = OAttribute.BuildAttributeInputField(inputText, contentTitle);
       
        string firstValue = "1";
        string secondValue = "2";
        string thirdValue = "3";
        string[] values = { firstValue, secondValue, thirdValue };
        string vectorObjectTitle = "Test Vector Object";
        OAttributeObject vectorAttribute = OAttribute.BuildAttributeVector(values, vectorObjectTitle, "\n");
        //add Slider
        //CONTENT
        OAttributeObject[] Content = new OAttributeObject[2];
        Content[0] = inputTextAttribute;
        Content[1] = vectorAttribute;
        OrionWindow window = OWindow.CreateWindow(OWindow.WindowSize.large);
        string header = "Input Objects Window";
        window.SetWindowData(header, Content);
    }
    void BuildDataWindow()
    {
        //button
        UnityEvent changeImage = new UnityEvent();
        changeImage.AddListener(ChangeImage);
        string buttonText = "Change Image";
        buttonHeight = 15;
        buttonWidth = 30;
        OAttributeObject buttonObject = OAttribute.BuildAttributeButton(buttonText, buttonWidth, buttonHeight, changeImage);
        OAttributeObject imageObject = OAttribute.BuildAttributeImage(testImages[0], imageWidth, imageHeight);
        imageInWindow = imageObject as OImage;
        //CONTENT
        OAttributeObject[] Content = new OAttributeObject[2];
        Content[0] = imageObject;
        Content[1] = buttonObject;
        OrionWindow window = OWindow.CreateWindow(OWindow.WindowSize.large);
        string header = "Data Objects Window";
        window.SetWindowData(header, Content);
    }
    void ChangeImage()
    {
       
        int totalImages = testImages.Count;
        if (currentImage + 1 > totalImages)
        {
            currentImage = 0;
        }
        else
        {
            currentImage += 1;

        }
        currentSprite = testImages[currentImage];
        imageInWindow.UpdateOImage( imageWidth, imageHeight, currentSprite);
    }
    
}

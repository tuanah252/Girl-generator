using UnityEngine;
using UnityEngine.UI;

public class ImageZoom : MonoBehaviour
{
   
    private Image image;
    private Button button;
    private bool isFullScreen = false;
    private Vector3 originalPosition;
    private Vector2 originalSize;
    public Vector3 fullScreenPosition = new Vector3(-2.66f,5.15f,0);
    private Vector2 fullScreenSize;

    // Start is called before the first frame update
    void Start()
    {
        
        image = GetComponent<Image>();

       
        button = GetComponent<Button>();

       
        button.onClick.AddListener(OnButtonClick);

        
        originalPosition = transform.position;
        originalSize = image.rectTransform.sizeDelta;

        
        fullScreenSize = new Vector2(Screen.width, Screen.height);
    }

    
    void OnButtonClick()
    {
        
        isFullScreen = !isFullScreen;

        
        if (isFullScreen)
        {
            transform.position = fullScreenPosition;
            image.rectTransform.sizeDelta = fullScreenSize;
            image.rectTransform.SetAsLastSibling();
        }
        else
        {
            transform.position = originalPosition;
            image.rectTransform.sizeDelta = originalSize;
        }
    }
}
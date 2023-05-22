using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class AddImagesToPlaceholders : MonoBehaviour
{
    public Image[] imageHolders;
    public Sprite[] imagesToAdd;

    private int currentImageIndex;
    private List<Sprite> remainingImages;

    private void Start()
    {
        currentImageIndex = 0;
        remainingImages = new List<Sprite>(imagesToAdd);
    }

    public void AddNextImage()
    {
        if (remainingImages.Count > 0)
        {
            int randomImageIndex = Random.Range(0, remainingImages.Count);
            Sprite randomImage = remainingImages[randomImageIndex];

            imageHolders[currentImageIndex].sprite = randomImage;
            remainingImages.RemoveAt(randomImageIndex);

            currentImageIndex = (currentImageIndex + 1) % imageHolders.Length;
        }
        else
        {
            ResetImages();
        }
    }

    private void ResetImages()
    {
        remainingImages = new List<Sprite>(imagesToAdd);

        for (int i = 0; i < imageHolders.Length; i++)
        {
            imageHolders[i].sprite = null;
        }

        currentImageIndex = 0;
    }
}



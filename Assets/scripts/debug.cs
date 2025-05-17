using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;


public class debug : MonoBehaviour
{
    [SerializeField]
    public Text debugText;

    [SerializeField]
    ARTrackedImageManager m_TrackedImageManager;

    void OnEnable() => m_TrackedImageManager.trackedImagesChanged += OnChanged;

    void OnDisable() => m_TrackedImageManager.trackedImagesChanged -= OnChanged;

    void OnChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {
        foreach (var newImage in eventArgs.added)
        {
            debugText.text += "new image \n";
        }

        foreach (var updatedImage in eventArgs.updated)
        {
            debugText.text += "image update \n ";
        }

        foreach (var removedImage in eventArgs.removed)
        {
            debugText.text += "image removed \n";
        }
    }
}

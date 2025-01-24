using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class PrefabUreticisi : MonoBehaviour
{
    [SerializeField] private GameObject ejderPrefab;
    [SerializeField] private Vector3 offsetPrefab;
    private GameObject ejder;
    private ARTrackedImageManager aRTrackedImageManager;
    private void OnEnable()
    {
        aRTrackedImageManager = gameObject.GetComponent<ARTrackedImageManager>();
        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }
    private void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            ejder = Instantiate(ejderPrefab, image.transform);
            ejder.transform.position += offsetPrefab;
        }
    }
}

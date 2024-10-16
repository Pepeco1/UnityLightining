using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookupSequencer : MonoBehaviour
{

    [SerializeField] List<Transform> cameraContainers = new List<Transform>();
    int currentCameraIndex = -1;

    [ContextMenu("Next Camera")]
    public void NextCamera()
    {

        cameraContainers[currentCameraIndex].gameObject.SetActive(false);
        currentCameraIndex = (currentCameraIndex + 1) % cameraContainers.Count;
        cameraContainers[currentCameraIndex].gameObject.SetActive(true);

    }

}

using UnityEngine;
using UnityEngine.UI;

public class canvasCamera : MonoBehaviour {
    
    RawImage rawImage;
    WebCamTexture webcam;

    // Use this for initialization
    void Start ()
    {
        webcam = new WebCamTexture(WebCamTexture.devices[0].name, 1280, 720, 30);
        rawImage = GetComponent<RawImage>();
        rawImage.texture = webcam;

        WebCamDevice[] devices;
        devices = WebCamTexture.devices;

        webcam.Play();
    }
}
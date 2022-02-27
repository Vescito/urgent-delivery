using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenToggle : MonoBehaviour
{
    public void Fullscene (bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
}

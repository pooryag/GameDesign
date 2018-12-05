using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Staythesame : MonoBehaviour {

    public float orthographicSize = 6.218637f;
    public float aspect = 1.33333f;
    void Start()
    {
        Camera.main.projectionMatrix = Matrix4x4.Ortho(
                -orthographicSize * aspect, orthographicSize * aspect,
                -orthographicSize, orthographicSize,
                Camera.main.nearClipPlane, Camera.main.farClipPlane);
    }
}



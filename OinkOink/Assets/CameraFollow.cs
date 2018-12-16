using UnityEngine;
using Cinemachine;



public class CameraFollow : MonoBehaviour
{
    private Transform m_Follow;
    public GameObject disk;
    //CinemachineCameraBase virtualCamera;
    //public float distanceToObject = 15f;
    public CinemachineVirtualCameraBase virtualCam;
    //public CinemachineVirtualCameraBase switchCameraTo;

    void Start()
    {
        
        virtualCam = Instantiate(Resources.Load("CMvcam", typeof(CinemachineVirtualCameraBase))) as CinemachineVirtualCameraBase;
        m_Follow = disk.transform;
        if (Spawn.ballCount != 4 && Spawn.AnchorIndicator!=0)
        {
            Follow(virtualCam);
        }
        
    }

    private void Update()
    {

        m_Follow = disk.transform;
        // Follow(virtualCam);

        if (Spawn.ballCount != 4 && Spawn.AnchorIndicator != 0)
        {
            Follow(virtualCam);
        }

    }

    // Update is called once per frame


    public void Follow(CinemachineVirtualCameraBase vcam)
    {
        vcam.Follow = m_Follow;
    }
}


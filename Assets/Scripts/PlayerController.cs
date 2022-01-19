using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public CharacterController controller;
    public GameObject firstPersonCam;
    public GameObject thirdPersonCam;

    void Update()
    {
        ProcessMovement();
        CameraChange();
    }
    void ProcessMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime); 
    }

    void CameraChange()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            if(firstPersonCam.activeSelf)
            {
                firstPersonCam.SetActive(false);
                thirdPersonCam.SetActive(true);
            }
            else if(thirdPersonCam.activeSelf)
            {
                
                thirdPersonCam.SetActive(false);
                firstPersonCam.SetActive(true);
            }
        }
    }
}

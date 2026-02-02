using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
   public Camera mainCam;
  


    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();
        mousePos.z = 9.5f;
        transform.position = mainCam.ScreenToWorldPoint(mousePos);
        transform.forward = mainCam.transform.forward;

    }

   

}

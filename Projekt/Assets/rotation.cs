using UnityEngine;

public class MouseLook : MonoBehaviour
{
  public float sensitivity = 2.0f;

  void Update()
  {
    float mouseX = Input.GetAxis("Mouse X") * sensitivity;
    float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

    transform.Rotate(Vector3.up, mouseX);
    transform.Rotate(Vector3.left, mouseY);
  }

  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
  }


}


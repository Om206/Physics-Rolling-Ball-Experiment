using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 1.0f;
    public Vector3 resetRotation = Vector3.zero;

    [SerializeField] KeyCode x;
    void Update()
    {
        // Move the camera forward, backward, left, or right
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;

        // Move the camera up or down
        float upDown = Input.GetAxis("UpDown");
        transform.position += new Vector3(0, upDown, 0) * moveSpeed * Time.deltaTime;

        // Rotate the camera left or right
        float rotate = Input.GetAxis("Rotate");
        transform.Rotate(0, rotate * rotateSpeed, 0);
        
        float rotate1 = Input.GetAxis("Rotate1");
        transform.Rotate( rotate1 * rotateSpeed,0, 0);

        if(Input.GetKeyDown(x))
             transform.rotation = Quaternion.Euler(resetRotation);
    }
}

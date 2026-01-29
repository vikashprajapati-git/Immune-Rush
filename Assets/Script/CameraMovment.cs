using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    [SerializeField] float cameraSpeed;

    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}

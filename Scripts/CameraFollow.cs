using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, 0);
    void Update()
    {
        transform.position = new Vector3 (5f, target.position.y, target.position.z) + offset;       
    }
}

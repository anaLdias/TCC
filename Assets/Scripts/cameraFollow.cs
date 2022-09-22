using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public float minX, maxX;
    public float timeLerp;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), transform.position.y, transform.position.z);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z), timeLerp);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z), timeLerp);
        }
    }
}
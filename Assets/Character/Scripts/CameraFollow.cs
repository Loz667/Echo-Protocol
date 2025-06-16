using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float followSpeed = 8f;

    private Vector3 offset;

    private void Start()
    {
        if (playerTransform == null)
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        offset = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 targetPosition = new Vector3(playerTransform.position.x + offset.x,transform.position.y, playerTransform.position.z + offset.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }
}

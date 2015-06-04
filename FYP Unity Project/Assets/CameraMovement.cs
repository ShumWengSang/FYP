using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{

    public float damping;

    private GameObject player;
    private Vector3 offset;

    void Start()
    {
        player = GameObject.Find("Player");
        offset = player.transform.position - transform.position;
    }

    void LateUpdate()
    {
        float currentAngle = transform.eulerAngles.y;
        float desiredAngle = player.transform.eulerAngles.y;
        float angle = Mathf.LerpAngle(currentAngle, desiredAngle, Time.deltaTime * damping);
        Quaternion rotation = Quaternion.Euler(0, angle, 0);

        transform.position = player.transform.position - (rotation * offset);
        transform.LookAt(player.transform);
    }

    
}

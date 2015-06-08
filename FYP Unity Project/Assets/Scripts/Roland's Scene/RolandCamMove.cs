using UnityEngine;
using System.Collections;
using InControl;
public class RolandCamMove : MonoBehaviour
{
    InputControl control;
    InputDevice device;
    public Transform targetObject;

    Vector3 Direction;
    // Use this for initialization
    void Start()
    {
        Direction = new Vector3(0, 0, -1);
        device = InputManager.ActiveDevice;
        control = device.GetControl(InputControlType.Action1);
    }

    // Update is called once per frame
    void Update()
    {
        if (InputManager.ActiveDevice.Action1.WasPressed)
        {
            targetObject.transform.position += new Vector3(0, 1, 0) * Time.fixedDeltaTime;
        }

        var inputDevice = InputManager.ActiveDevice;

        // Move focus with directional inputs.
        if (inputDevice.Direction.Up)
            transform.position += Vector3.Cross(new Vector3(0, 0, 1), Direction);

        if (inputDevice.Direction.Down)
            transform.position += Vector3.Cross(new Vector3(0, 0, -1), Direction);

        if (inputDevice.Direction.Left)
            transform.position += Vector3.Cross(new Vector3(-1, 0, 0), Direction);

        if (inputDevice.Direction.Right)
            transform.position += Vector3.Cross(new Vector3(1, 0, 0), Direction);



    }
}

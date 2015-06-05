using UnityEngine;
using System.Collections;
using InControl;
public class RolandCamMove : MonoBehaviour
{
    InputControl control;
    InputDevice device;
    public Transform targetObject;
    // Use this for initialization
    void Start()
    {
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
        if (inputDevice.Direction.Up.WasPressed)
            transform.position += new Vector3(0, 0, 1);

        if (inputDevice.Direction.Down.WasPressed)
            transform.position += new Vector3(0, 0, -1);

        if (inputDevice.Direction.Left.WasPressed)
            transform.position += new Vector3(-1, 0, 0);

        if (inputDevice.Direction.Right.WasPressed)
            transform.position += new Vector3(1, 0, 0);

    }
}

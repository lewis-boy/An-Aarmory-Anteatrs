using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Test : MonoBehaviour
{
    bool acc;
    TMP_Text text;
    void Start()
    {
        if (null != StepCounter.current)
        {
            InputSystem.EnableDevice(StepCounter.current);
            acc = true;
        }
        else
        {
            acc = false;
        }

        text = gameObject.GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (acc)
        {
            //Vector3 acceleration = Accelerometer.current.acceleration.ReadValue();
            //text.text = $"Accelerator: { (int)acceleration.x }, { (int)acceleration.y }, { (int) acceleration.z }";
            text.text = $"StepCounter: { StepCounter.current.stepCounter.ReadValue() }";
        }
    }
}

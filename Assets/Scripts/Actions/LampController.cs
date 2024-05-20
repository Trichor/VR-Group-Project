using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class LampController : MonoBehaviour
{
    public Light lampLight;
    private bool isOn = false;

    void Start()
    {
        lampLight.enabled = isOn;
    }

    public void ToggleLight()
    {
        isOn = !isOn;
        lampLight.enabled = isOn;
    }

 
}

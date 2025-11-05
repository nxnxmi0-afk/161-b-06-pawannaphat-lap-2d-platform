using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;                 // ลาก Slider มาวางใน Inspector
    [SerializeField] private Vector3 localOffset = new(0f, 1.2f, 0f);

    // ให้ Character เรียกตอนสร้าง
    public void AttachTo(Transform target, Vector3? overrideOffset = null)
    {
        transform.SetParent(target, false);
        transform.localPosition = overrideOffset ?? localOffset;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;
    }

    public void SetMax(float max)
    {
        if (slider == null) return;
        slider.minValue = 0f;
        slider.maxValue = max;
        slider.value = max;
    }

    public void SetValue(float value)
    {
        if (slider == null) return;
        slider.value = Mathf.Clamp(value, slider.minValue, slider.maxValue);
    }
}



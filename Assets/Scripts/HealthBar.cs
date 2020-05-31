using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider = null;
    [SerializeField] private Gradient gradient = null;
    [SerializeField] private Image fill = null;

    private void Start()
    {
        if (slider == null) { Debug.LogError("ERROR - Slider object in HealthBar not set!"); }
        if (gradient == null) { Debug.LogError("ERROR - Gradient object in HealthBar not set!"); }

    }

    public void setMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }

    public void setHealth( int health )
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}

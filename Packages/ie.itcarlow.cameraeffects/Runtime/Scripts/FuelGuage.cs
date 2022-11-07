using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelGuage : MonoBehaviour
{
    public Slider slider;
    public Image fill;
    public int fuelRate;
    public int fuelGain;

    private void setFuel(int t_fuel)
    {
        if (t_fuel <= slider.maxValue)
        {
            slider.value = t_fuel;
        }
        else
        {
            slider.value = slider.maxValue;
        }
    }

    public void reduceFuel()
    {
        setFuel((int)slider.value - fuelRate);
    }

    public void setMaxFuel(int t_fuel)
    {
        slider.maxValue = t_fuel;
        slider.value = t_fuel;
    }

    public void gainFuel()
    {
        setFuel((int)slider.value + fuelGain);
    }
}

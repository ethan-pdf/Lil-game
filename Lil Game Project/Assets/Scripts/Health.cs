using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

   public void SetMaxHealth(int i)
    {
        slider.maxValue = i;
    }

   public void SetCurrentHealth(int i)
    {
        slider.value = i;
    }
}

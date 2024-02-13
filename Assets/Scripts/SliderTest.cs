using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    [SerializeField] private Slider slider;

    void Update()
    {
        MovingEnemy.speed = slider.value;
    }
}

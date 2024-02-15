using UnityEngine;
using UnityEngine.UI;

public class SliderTest : MonoBehaviour
{
    [SerializeField] private Slider sliderSpeed;
    [SerializeField] private Slider sliderTime;
    [SerializeField] private Slider sliderCount;
    [SerializeField] private Slider sliderRadius;


    private void Awake() {
        sliderSpeed.value = MovingEnemy.speed;
        sliderTime.value = EnemySpawn.waitTime;
        sliderCount.value = EnemySpawn.objectsCount;
        sliderRadius.value = MovingEnemy.radius;
    }

    void Update()
    {
        MovingEnemy.speed = updateValue(MovingEnemy.speed, sliderSpeed);
        EnemySpawn.waitTime = updateValue(EnemySpawn.waitTime, sliderTime);
        EnemySpawn.objectsCount = updateValue(EnemySpawn.objectsCount, sliderCount);
        MovingEnemy.radius = updateValue(MovingEnemy.radius, sliderRadius);
    }

    float updateValue(float _variable, Slider slider)
    {
        _variable = slider.value;
        return _variable;
    }
}

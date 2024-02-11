using UnityEngine;
using TMPro;

public class MovingSpawner : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private int startingPoint;
    [SerializeField] private Transform[] points;
    [SerializeField] private GameObject screen;
    [SerializeField] private TextMeshPro text;

    private  int i;


    private void Start() {
        Time.timeScale = 0f;
        transform.position = points[startingPoint].position;
    }

    private void Update() {
        if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
    }
}

using UnityEngine.SceneManagement;
using UnityEngine;


public class MovingEnemy : MonoBehaviour
{
    static public float speed;
    [SerializeField] private GameObject player;
    private Vector3 target;


    private void Start() {
        target = player.transform.position + new Vector3(Random.Range(-2f, 2f), 0);
    }

    private void Update() {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        Lose();
    }

    private void OnMouseDown() {
        Destroy(gameObject);
    }

    private void Lose()
    {
        if (transform.position.y == player.transform.position.y)
        {
            SceneManager.LoadScene(3);
        }
    }
}

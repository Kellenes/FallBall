using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //[SerializeField] private GameObject spawner;
    [SerializeField] private GameObject EnemyPrefab;


    private void Start() {
        StartCoroutine("spaswnKD");
    }

    IEnumerator spaswnKD()
    {
        yield return new WaitForSeconds(Random.Range((float)0.7, (float)1.8));
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        StartCoroutine("spaswnKD");
    }
}

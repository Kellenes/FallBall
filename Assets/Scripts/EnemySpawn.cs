using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //[SerializeField] private GameObject spawner;
    [SerializeField] private GameObject EnemyPrefab;
    static public float waitTime = 1.5f;
    static public float objectsCount = 1;


    private void Start() {
        StartCoroutine("spaswnKD");
    }

    IEnumerator spaswnKD()
    {
        yield return new WaitForSeconds(waitTime);
        Spawn();
    }

    public void Spawn()
    {
        for (int i = 0; i < objectsCount; i++)
        {
            Instantiate(EnemyPrefab, transform.position + new Vector3(Random.Range(-2.6f, 2.6f), 0), Quaternion.identity);
            
        }
        StartCoroutine("spaswnKD");
    }
}

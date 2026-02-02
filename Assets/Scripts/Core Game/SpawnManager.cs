using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] fruitsPrefab;
    public System.Action<float> onFruitDestroyed;
    public System.Action<float> onCaughtFruit;
    
    void Start()
    {
        StartCoroutine(SpawnFruit());
    }

    private IEnumerator SpawnFruit()
    {
        while (true)
        {
            int index = Random.Range(0, fruitsPrefab.Length);
            GameObject f = Instantiate(fruitsPrefab[index], new Vector3(Random.Range(-9, 5), 6, 0), Quaternion.identity);
            Fruits fruit = f.GetComponent<Fruits>();
            fruit.onOutOfBounds += HandleDestroyedFruit;
            fruit.onCatch += HandleCaughtFruit;
            yield return new WaitForSeconds(2);
        }
    }

    void HandleDestroyedFruit(float damage)
    {
        onFruitDestroyed?.Invoke(damage);
    }

    void HandleCaughtFruit(float p)
    {
        onCaughtFruit?.Invoke(p);
    }
}

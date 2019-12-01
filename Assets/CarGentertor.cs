using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGentertor : MonoBehaviour
{
    [SerializeField] public GameObject Car;
    [SerializeField] public Transform SpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCar());
    }

    private IEnumerator SpawnCar()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2,10));
            Instantiate(Car, SpawnPos.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}

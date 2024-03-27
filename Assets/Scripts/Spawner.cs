using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] drops;
    private float x1, x2;
    private float nextDropTime = 0f;
    public float dropInterval = 1f;

    private BoxCollider2D col;

    // Start is called before the first frame update
    void Awake()
    {
        col = GetComponent<BoxCollider2D>();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextDropTime)
        {
            SpawnSingleDrop();
            nextDropTime = Time.time + dropInterval;
        }
    }

    // Egy csepp kiejtése
    void SpawnSingleDrop()
    {
        // vél. pozíció
        float randomX = Random.Range(x1, x2);

        // vél. drop kiválasztása
        GameObject randomDrop = drops[Random.Range(0, drops.Length)];

        //Drop létrehozása:3
        Instantiate(randomDrop, new Vector3(randomX, transform.position.y, transform.position.z), Quaternion.identity);
    }
}

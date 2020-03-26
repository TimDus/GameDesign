using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roadspawn : MonoBehaviour
{
    public GameObject prefab;
    private GameObject lastPlatform;
    private GameObject prevPlatform;
    public bool check;
    public bool ready;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        GameObject[] platform = GameObject.FindGameObjectsWithTag("Road");
        foreach (GameObject h in platform)
        {
            lastPlatform = h;
        }
        StartCoroutine(coroutine());
    }
    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(0.5f);

        yield return new WaitUntil(() => lastPlatform.GetComponentInChildren<SpawnNew>().Ready());
        spawn();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(coroutine());
    }
    void spawn()
    {
        i++;
        prevPlatform = lastPlatform;
        lastPlatform = Instantiate(prefab, lastPlatform.transform.GetChild(0).position, Quaternion.identity);
        lastPlatform.name = "Road" + i.ToString();
    }

}
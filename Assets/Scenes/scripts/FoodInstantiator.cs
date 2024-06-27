using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement posicionAleatoriaDeClonePoint;
    public int cloneCount = 0;
    public int maxClones;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood), 0, interval);
        maxClones = Random.Range(3, 7);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CloneFood()
    {
        //DeactivateAll();
        if (cloneCount < maxClones)
        {
            cloneCount++;
            posicionAleatoriaDeClonePoint.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }

    }
    public void DeactivateAll()
    {
        for (int i = 0; i < alimentos.Length; i++)
        {
            alimentos[i].SetActive(false);
        }
    }



}


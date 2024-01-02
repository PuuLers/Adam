using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int SizeTrees;
    public int SizeGross;
    public Transform zero;
    public GameObject[] Gross;
    public GameObject[] Trees;
    public int Trees—ount;
    public int Gross—ount;
    

    private void Generate(GameObject[] array, int size, int count)
    {
        for (int i = 0; i < count; i++)
        {
            int rand = Random.Range(0, array.Length);
            var cell = Instantiate(array[rand], transform.position, Quaternion.identity);
            cell.transform.position = new Vector3(Random.Range(-size, size), Random.Range(-size, size), transform.position.z);
        }
    }


    void Start()
    {
        Generate(Gross, SizeGross, Gross—ount);
        Generate(Trees, SizeTrees, Trees—ount);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public GameObject Cube;
    private GameObject MySelf;
    public float MySpeed;
    private void Start()
    {
        MySelf = gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        Cube = GameObject.Find("A");
        transform.position = Vector3.MoveTowards(transform.position, Cube.transform.position, MySpeed * Time.deltaTime);
        transform.LookAt(Cube.transform.position);

    }
}

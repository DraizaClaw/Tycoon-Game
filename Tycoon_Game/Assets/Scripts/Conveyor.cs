using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor : MonoBehaviour
{
    //

    [SerializeField] private float speed;

    [SerializeField] private Vector3 ConveyorDirection;

    public List<GameObject> onConveyor;

    
    private void Update()
    {
        for (int i = 0; i <= onConveyor.Count -1; i++)
        {
            onConveyor[i].GetComponent<Rigidbody>().velocity = speed * ConveyorDirection * Time.deltaTime;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        onConveyor.Add(collision.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {
        onConveyor.Remove(collision.gameObject);
    }





}

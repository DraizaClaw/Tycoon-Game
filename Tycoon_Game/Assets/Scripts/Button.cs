using UnityEngine;

public class Button : MonoBehaviour
{
    //
    [SerializeField] private GameObject CratePrefab;
    [SerializeField] private Vector3 SpawnPoint;


    private void OnTriggerEnter(Collider other)
    {
        Instantiate(CratePrefab, SpawnPoint, Quaternion.identity);
    }



}

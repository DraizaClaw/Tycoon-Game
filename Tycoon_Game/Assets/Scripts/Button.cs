using UnityEngine;

public class Button : MonoBehaviour
{
    //
    [SerializeField] private GameObject CratePrefab;
    [SerializeField] private GameObject SpawnLocation;



    private void OnTriggerEnter(Collider other)
    {
        Instantiate(CratePrefab, SpawnLocation.transform.position, Quaternion.identity);
    }



}

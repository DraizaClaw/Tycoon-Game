using UnityEngine;

public class CameraController : MonoBehaviour
{
    //

    private Transform CameraTransform;
    [SerializeField] private GameObject player;


    private void Awake()
    {
        CameraTransform = GetComponent<Transform>();
    }


    private void Update()
    {
        CameraTransform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4, player.transform.position.z - 3);
    }



}

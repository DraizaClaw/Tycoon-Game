using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //


    private CharacterController Controller;


    [SerializeField] private float speed;


    private void Awake()
    {
        Controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        GetComponent<Transform>().position = new Vector3(transform.position.x, 0.58f, transform.position.z);

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(Horizontal, 0f, Vertical);

        if (direction.magnitude >= 0.1f)
        {
            Controller.Move(direction * speed * Time.deltaTime);
        }
    
    
    
    }



}

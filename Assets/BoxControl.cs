using UnityEngine;
public class BoxControl : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f; 

    public Transform respawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveY) * speed;

        rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter:" + other.gameObject.tag);
        
        if (other.gameObject.tag == "FinishZone")
        {
            transform.position = respawnPoint.position;
        }
    }
}

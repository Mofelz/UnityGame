using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    Rigidbody rb;

    private CharacterController controller;
    private float playerSpeed = 4.0f;
    float speed = 5.0f;

    static public int money;
    [SerializeField]
    public Text TextMoney;

    void Start()
    {
        money = 0;
        speed = 5.0f;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-1 * Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.Rotate(0, -1, 0);
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            /*transform.Rotate(0, 1, 0)*/;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (money == 1)
        {
            SceneManager.LoadScene(2);
        }
    }
}
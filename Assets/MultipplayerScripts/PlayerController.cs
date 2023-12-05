using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviourPunCallbacks
{
    public float speed = 1f;
    public float rspeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (!photonView.IsMine)
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f;
        float rspeed = 5f;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, -rspeed * Time.deltaTime, 0f);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, rspeed * Time.deltaTime, 0f);
        }
    }
}

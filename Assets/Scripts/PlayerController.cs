using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody rb;
    private PlayerControls controls;
    public float speed = 220;
    // Start is called before the first frame update
    void Start()
    {
        controls = new PlayerControls();
        controls.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = controls.Player.Move.ReadValue<Vector2>();
        rb.AddForce(dir.x*speed*Time.deltaTime, 0, dir.y*speed*Time.deltaTime );
        if(transform.position.y<-5){
            PlayerManager.gameOver=true;
            this.enabled = false;
        }

    }
}

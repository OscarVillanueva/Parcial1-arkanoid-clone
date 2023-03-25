using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallController : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GameManager.sharedInstance.StartLevel(4, "Level1");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MovePlayer();
    }

    /*
     * Move the player using the rigidbody
     */
    private void MovePlayer()
    {
        Vector2 currentMovement = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rigidBody.velocity = currentMovement.normalized * 10;
    }

    [ContextMenu("Init file")]
    public void InitSaveFile()
    {
        // 0 Amarillo, 1 Rojo, 2 Azul, 3 Verde
        new FileReaderManager().WriteIntoFile(1,0,1);
    }
    
    [ContextMenu("Read file")]
    public void ReadFile()
    {
        new FileReaderManager().ReadFile();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{

    Vector2 moveInput;
    PlayerController _playerController;
    
    public float modifiedSpeed; //For wepaon holding Speeds

    bool dash = false;

    float speed;

    float dashCooldown;

    Animator movementAnimator;
    public static Vector3 playerMovement;

    public static Vector3 currentPosition;

    public static event EventHandler OnPlayerMoved;


    Rigidbody player_rb;

    WeaponController weaponController;


    private void Awake()
    {
        _playerController = new PlayerController();
        player_rb = gameObject.GetComponent<Rigidbody>();

        weaponController = gameObject.GetComponent<WeaponController>();

        //_playerController.PlayerMovement.Movement.performed += UpdateWhenMoved;
        //_playerController.PlayerMovement.Movement.canceled += UpdateWhenMoved;

        PlayerManager.OnPlayerAim += AimMovement;
        PlayerManager.OnPlayerStopAim += ResumeMoving;
        //PlayerManager.OnWeaponChange += ChangedWeapon;
        weaponController.FinishedWeaponChange += ChangedWeapon;


    }

    private void ChangedWeapon(object sender, EventArgs e)
    {
        //On weapon switch, reset to base speed, THEN apply slow speed
        modifiedSpeed = speed;
        modifiedSpeed *= weaponController.currentWeapon.walkMultiplier;
    }

    private void Start()
    {
        dashCooldown = 0;
        movementAnimator = GetComponent<Animator>();
        speed = PlayerInfo.instance.movementSpeed;
        modifiedSpeed = speed*weaponController.currentWeapon.walkMultiplier;
    }

    bool isStopped = false;

    public void UpdateWhenMoved(InputAction.CallbackContext e)
    {

    }

    public static float slowSpeed = 1.0f;
    public static float environmentalEffectSpeed = 1.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = _playerController.PlayerMovement.Movement.ReadValue<Vector2>();

        if (!isStopped)
        {
            //stores the player's WASD input as a vector2, with AD as the x-axis and WS as the y-axis
            speed = PlayerInfo.instance.movementSpeed;
        }
        else
        {
            speed = PlayerInfo.instance.movementSpeed * slowSpeed;

        }

        //playerMovement = new Vector3(moveInput.x, 0, moveInput.y) * speed;
        playerMovement = new Vector3(moveInput.x, 0, moveInput.y) * modifiedSpeed * slowSpeed * environmentalEffectSpeed;

        //basic player movement
        //moves the game object this script is attached to based on WASD input 

        movementAnimator.SetFloat("MovementSpeed", playerMovement.magnitude);

        this.gameObject.GetComponent<Rigidbody>().velocity = playerMovement;

        //this.gameObject.GetComponent<Rigidbody>().AddForce(playerMovement*100f);

        currentPosition = transform.position;
    }

    float tempSpeed;

    void AimMovement(object sender, EventArgs e)
    {
        isStopped = true;
        playerMovement = Vector3.zero;
        moveInput = Vector3.zero;
        slowSpeed = 0.3f;
    }
    void ResumeMoving(object sender, EventArgs e)
    {
        isStopped = false;
        slowSpeed = 1.0f;
    }



    private void OnEnable()
    {
        //begins player movement functions
        _playerController.PlayerMovement.Enable();
    }


    private void OnDisable()
    {
        //ends player movement functions
        _playerController.PlayerMovement.Disable();
    }

}

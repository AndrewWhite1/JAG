using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    PlayerControllers controls;

    Vector2 leftArmVector;
    Vector2 rightArmVector;

    private void Awake()
    {
        controls = new PlayerControllers();

        //setup movement input
        controls.Move.Jump.performed += ctx => Move(0);
        controls.Move.Left.performed += ctx => Move(1);
        controls.Move.Down.performed += ctx => Move(2);

        //setup Left Arm input
        controls.LeftArm.Rotate.performed += ctx => leftArmVector = ctx.ReadValue<Vector2>();
        controls.LeftArm.Rotate.performed += ctx => leftArmVector = Vector2.zero;
        controls.LeftArm.Pickup.performed += ctx => Pickup(false);
        controls.LeftArm.Use.performed += ctx => Pickup(false);

        //setup Right Arm input
        controls.RightArm.Rotate.performed += ctx => rightArmVector = ctx.ReadValue<Vector2>();
        controls.RightArm.Rotate.performed += ctx => rightArmVector = Vector2.zero;
        controls.RightArm.Pickup.performed += ctx => Pickup(true);
        controls.RightArm.Use.performed += ctx => Pickup(true);
    }
    void Move(int dir)
    {
        if(dir == 0)
        {

        }
        else if (dir == 1)
        {

        }
        else if (dir == 2)
        {

        }
    }
    void Pickup(bool right)
    {
        if (right)
        {

        }
        else
        {

        }
    }
    void Use(bool right)
    {
        if (right)
        {

        }
        else
        {

        }
    }
}

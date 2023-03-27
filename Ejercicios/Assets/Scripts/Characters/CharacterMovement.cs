using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterMovement : MonoBehaviour
{
    private const int MaxDistance = 10;
    
    [Header ("SetUp")]
    [SerializeField] private Rigidbody rigidBody;
    
    [SerializeField] private Transform feetPivot;

    [Header("Movement")]
    [SerializeField] private float speed;

    [SerializeField] private float minJumpDistance;
    private Vector3 _currentMovement;

    [Range(0, 1000)]
    [SerializeField] private float jumpForce = 10;
    
    private bool _isJumpInput;

    private void OnValidate()
    {       
        rigidBody ??= GetComponent<Rigidbody>();
    }

    private void Update()
    {          
        transform.Translate(speed * Time.deltaTime * _currentMovement);
    }

    private void FixedUpdate()
    {
        RaycastHit hit;

        if (_isJumpInput 
            && Physics.Raycast(feetPivot.position, Vector3.down, out hit , MaxDistance)
            && hit.distance <= minJumpDistance)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            _isJumpInput = false;
        }
    }

    public void OnMove(InputValue input)
    {
        var movement = input.Get<Vector2>();
        _currentMovement = new Vector3(movement.x, _currentMovement.y, movement.y);
    }

    public void OnJump()
    {
        _isJumpInput = true;
    }

    private void OnSprint(InputValue input)
    {
        Debug.Log($"sprint: {input.isPressed}");
         
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
    }
}

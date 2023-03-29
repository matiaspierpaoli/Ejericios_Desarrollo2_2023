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

    //[SerializeField] private float jumpBufferTime;
    private Coroutine _jumpCoruotine;
    [SerializeField] private float bufferTime;


    //private bool _isJumpInput;

    private void OnValidate()
    {
        rigidBody ??= GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //    RaycastHit hit;

        //    if (_isJumpInput 
        //        && Physics.Raycast(feetPivot.position, Vector3.down, out hit , MaxDistance)
        //        && hit.distance <= minJumpDistance)
        //    {
        //        rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        //        _isJumpInput = false;
        //    }

        rigidBody.velocity = _currentMovement* speed + Vector3.up* rigidBody.velocity.y;
    }

    public void OnMove(InputValue input)
    {
        var movement = input.Get<Vector2>();
        _currentMovement = new Vector3(movement.x, _currentMovement.y, movement.y);
    }
     
    public void OnJump()
    {
        //_isJumpInput = true;
        //CancelInvoke(nameof(CancelJumpInput));
        //Invoke(nameof(CancelJumpInput), jumpBufferTime);

        if (_jumpCoruotine != null) 
            StopCoroutine(JumpCoroutine(bufferTime));

        _jumpCoruotine = StartCoroutine(JumpCoroutine(bufferTime));

    }


    private void OnSprint(InputValue input)
    {
        Debug.Log($"sprint: {input.isPressed}");
         
    }

    //private void CancelJumpInput()
    //{
    //    _isJumpInput = false;
    //}

    private IEnumerator JumpCoroutine(float bufferTime)
    {

        if (!feetPivot)
            yield break;

        float timeElapsed = 0;
        while (timeElapsed <= bufferTime)
        {           
            yield return new WaitForFixedUpdate();
            
            if (Physics.Raycast(feetPivot.position, Vector3.down, out var hit, MaxDistance)
            && hit.distance <= minJumpDistance)
            {
                rigidBody.velocity = new Vector3(rigidBody.velocity.x, 0, rigidBody.velocity.z);
                rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                yield break;
            }

            timeElapsed += Time.fixedDeltaTime;
        }    
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(feetPivot.position, feetPivot.position + Vector3.down * minJumpDistance);
    }
}

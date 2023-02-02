using UnityEngine;

public class VisitorMovement : MonoBehaviour
{
    [SerializeField] CharacterController _characterController;

    [SerializeField] float _speed = 10f;

    public void Move(float x, float z)
    {
        Vector3 move = x * _characterController.transform.right + z * _characterController.transform.forward;
        _characterController.Move(move * _speed * Time.deltaTime);
    }
}
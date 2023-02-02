using UnityEngine;

public class CameraLook : MonoBehaviour
{
    [SerializeField] Transform _camera;
    [SerializeField] Transform _player;

    float _xRotation = 0f;

    public void UpdateLook(float x, float y)
    {
        _xRotation -= y;
        _xRotation = Mathf.Clamp(_xRotation, -30f, 30f);

        _camera.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _player.Rotate(Vector3.up * x);
    }
}
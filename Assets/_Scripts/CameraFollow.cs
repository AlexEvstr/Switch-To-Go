using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private GameObject _player;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - _player.transform.position;
    }

    void Update()
    {
        transform.position = _player.transform.position + offset;
    }

}
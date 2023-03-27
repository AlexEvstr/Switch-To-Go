using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Update()
    {
        gameObject.transform.Rotate(0, 0, 45 * -_speed * Time.deltaTime);
    }
}

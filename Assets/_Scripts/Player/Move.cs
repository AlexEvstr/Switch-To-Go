using System.Collections;
using UnityEngine;

public class Move : MonoBehaviour
{
    private float _speed = 3.0f;
    private bool _directionChanged;

    private void Start()
    {
        StartCoroutine(Mover());
    }

    private IEnumerator Mover()
    {
        while (true)
        {
            MovePlayer();
            yield return new WaitForSeconds(0);
        }
    }

        private void MovePlayer()
    {
        if (_directionChanged)
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
        else if (!_directionChanged)
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            ChangeDirection();
    }

    private void ChangeDirection()
    {
        _directionChanged = !_directionChanged;
    }
}

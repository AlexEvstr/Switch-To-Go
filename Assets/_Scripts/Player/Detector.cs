using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Detector : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private GameObject _startPanel;
    private float _score;
    public RaycastHit2D hit;

    private void Start()
    {
        _score = 0;
        Time.timeScale = 0;
    }

    private void Update()
    {
        hit = Physics2D.Raycast(transform.position, Vector2.right * transform.localScale.x, 0);
        if (!_startPanel.activeInHierarchy)
        {
            if (hit.collider != null && hit.collider.tag == "Road")
            {
                _score++; ;
                _scoreText.text = _score.ToString();

            }
            else
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}

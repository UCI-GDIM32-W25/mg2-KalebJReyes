using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform _Spawn;

    private float _randomTimer;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_coin, _Spawn.position, Quaternion.identity);
        _randomTimer = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        _randomTimer -= Time.deltaTime;
        if (_randomTimer <= 0) 
        {
            Instantiate(_coin, _Spawn.position, Quaternion.identity);
            _randomTimer = Random.Range(0, 3);
        }
        Debug.Log(_randomTimer);
    }

    public void UpdateText(int points) 
    {
        _pointsText.text = points.ToString();
    }
}

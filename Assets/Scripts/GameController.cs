using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private GameObject _coin;
    [SerializeField] private Transform _Spawn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int chance = Random.Range(1, 1000);
        if (chance == 7) 
        {
            Instantiate(_coin, _Spawn.position, Quaternion.identity);
        }
    }

    public void UpdateText(int points) 
    {
        _pointsText.text = points.ToString();
    }
}

using UnityEngine;


public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private GameObject _player;
    private Vector3 _playerPosition;



    private void Update()
    {
        _playerPosition = _player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition, speed * Time.deltaTime);
    }

    public void StartChase()
    {
        enabled = true;
    }
    public void StopChase()
    {
       enabled=false;
    }



}

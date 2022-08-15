using System.Collections.Generic;
using UnityEngine;

public class SnakeBlock : MonoBehaviour
{
    public Transform Head;
    public float BlockSize;

    private List<Transform> _blocks = new List<Transform>();
    private List<Vector3> _locations = new List<Vector3>();
    private void Awake()
    {
        _locations.Add(Head.position);
    }

    public void Grow(int value)
    {
        for (int i = 0; i < value; i++)
        {
            Transform Block = Instantiate(Head, _locations[_locations.Count - 1], Quaternion.identity, transform);
            Block.GetComponent<Collider>().enabled = false;
            Block.GetChild(0).GetComponentInChildren<Renderer>().enabled = false;
            _blocks.Add(Block);
            _locations.Add(Block.position);
        }
    }
    public void Shrink()
    {
        Destroy(_blocks[0].gameObject);
        _blocks.RemoveAt(0);
        _locations.RemoveAt(1);
    }

    private void Update()
    {
        float distance = (Head.position - _locations[0]).magnitude;

        if (distance > BlockSize)
        {
            Vector3 direction = (Head.position - _locations[0]).normalized;

            _locations.Insert(0, _locations[0] + direction * BlockSize);
            _locations.RemoveAt(_locations.Count - 1);

            distance -= BlockSize;
        }

        for (int i = 0; i < _blocks.Count; i++)
        {
            _blocks[i].position = Vector3.Lerp(_locations[i + 1], _locations[i], distance / BlockSize);
        }
    }
}

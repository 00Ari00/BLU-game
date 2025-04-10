using System;
using Cinemachine;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MapTransition : MonoBehaviour
{
    [SerializeField] PolygonCollider2D mapBoundary;
    CinemachineConfiner confinder;

    [SerializeField] Direction direction;
    enum Direction {Up, Down, Left, Right}

    float posChange = 3.5f;

    [System.Obsolete]
    private void Awake()
    {
        confinder = FindObjectOfType<CinemachineConfiner>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            confinder.m_BoundingShape2D = mapBoundary;
            UpdatePlayerPosition(collision.gameObject);
        }
    }

    private void UpdatePlayerPosition(GameObject player)
    {
        Vector3 newPos = player.transform.position;

        switch (direction) 
        {
            case Direction.Up:
                newPos.y += posChange;
                break;
            case Direction.Down:
                newPos.y -= posChange;
                break;
            case Direction.Left:
                newPos.x -= posChange;
                break;
            case Direction.Right:
                newPos.x += posChange;
                break;
        }

        player.transform.position = newPos;
    }
}

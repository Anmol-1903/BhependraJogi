using UnityEngine;
public class ObstacleMove : MonoBehaviour
{
    [SerializeField] Transform[] _movePoints;
    [SerializeField] float _moveSpeed;
    int currentIndex;


    private void Start()
    {
        currentIndex = 0;
    }

    private void Update()
    {
        NPCMove();
    }

    void NPCMove()
    { 
        if(transform.position != _movePoints[currentIndex].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, _movePoints[currentIndex].transform.position, _moveSpeed * Time.deltaTime);
        }
        else
        {
            currentIndex = (currentIndex + 1) % _movePoints.Length;
        }
    }
}

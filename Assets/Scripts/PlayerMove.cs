
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform _leftWall;
    [SerializeField] private Transform _rightWall;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 step = new Vector3(hor, ver, 0);
        Vector3 nextPosition = transform.position + step * (moveSpeed * Time.deltaTime);

        float clampedX = Mathf.Clamp(nextPosition.x, _leftWall.position.x, _rightWall.position.x);
        nextPosition.x = clampedX;

        transform.position = nextPosition;
    }
}

using UnityEngine;

public class Controls : MonoBehaviour
{
    public Rigidbody Player;
    public Stage Stage;
    public float Speed;
    private float _turnVelocity = 1;

    private void FixedUpdate()
    {
        Player.velocity = new Vector3 (0, 0, Speed);
        if (Input.GetKey(KeyCode.A))
        {
            Player.velocity += new Vector3(-Speed + _turnVelocity, 0, 0);
            if (Player.position.x < Stage.Min_x) Player.position = new Vector3(Stage.Min_x, Player.position.y, Player.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.velocity += new Vector3 (Speed + _turnVelocity, 0, 0);
            if (Player.position.x > Stage.Max_x) Player.position = new Vector3(Stage.Max_x, Player.position.y, Player.position.z);
        }
    }
}

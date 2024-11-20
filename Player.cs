using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D player;
    private float movePlayer;

    void Start()
    {
        
    }
    //Move Player - movimentar personagem
    void Update()
    {
        movePlayer = Input.GetAxis("Horizontal");
        player.linearVelocity = new Vector2(movePlayer * speed, player.linearVelocityY);
        //Flip - movimento de rotação
        if (movePlayer > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        if (movePlayer < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
    }
}

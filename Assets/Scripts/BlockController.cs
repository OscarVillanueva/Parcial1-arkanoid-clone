using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BlockController : MonoBehaviour
{
    [SerializeField] private BlockTypes type;
    [SerializeField] private int baseMultiplayer = 1;
    
    private Block block;
    private int hits;

    private void Start()
    {
        hits = 0;
        DefineBlock();
        GetComponent<SpriteRenderer>().color = block.BlockColor;
    }

    private void DefineBlock()
    {
        block = type switch
        {
            BlockTypes.SOFT => new SoftBlock(),
            BlockTypes.HARD => new HardBlock(),
            BlockTypes.POWERUP => new PowerBlock(),
            BlockTypes.HIDE => new PowerBlock(),
            _ => block
        };
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) {

            hits += (baseMultiplayer * GameManager.sharedInstance.PowerMultiplayer);

            if (hits >= block.Hardness)
            {
                block.HandleDestroy();
                Destroy(gameObject);
            }
        }
    }
}

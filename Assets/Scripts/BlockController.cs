using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BlockController : MonoBehaviour
{
    [SerializeField] private BlockTypes type;
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
        switch(type)
        {
            case BlockTypes.SOFT:
                block = new SoftBlock();
                break;

            case BlockTypes.HARD:
                block = new HardBlock();
                break;

            case BlockTypes.POWERUP:
                block = new PowerBlock();
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) {

            hits = hits + 1;

            if (hits >= block.Hardness) Destroy(gameObject);
        }
    }
}

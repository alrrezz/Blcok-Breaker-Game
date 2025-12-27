using UnityEngine;


public class Block : MonoBehaviour
{
    //Conf Parameters
    [SerializeField] AudioClip[] blockSounds;
    [SerializeField] GameObject blockSparklesVFX;
    [SerializeField] Sprite[] hitSprites;
    [Range(10 , 90)][SerializeField] int itemSpawnPrabiblityPersent = 30;
    [SerializeField] GameObject[] itemPrefab;
    [SerializeField] float itemSpeed = 40f;
    int maxHits;
    int spriteIndex;

    //cashed refrence
    Level level;
    GameStatus status;

    //State Variables
    [SerializeField] int timesHit;    // for debug purposes

    private void Start()
    {
        CountBreakableBlocks();
        status = FindObjectOfType<GameStatus>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "One Shot Breakable"|| 
            tag == "Two Shot Breakable"|| 
            tag == "Three Shot Breakable"||
            tag == "Invisible")
        {
            HandleHits();
        }
        else
        {
            PlaySoundEffects();
        }
    }

    private void HandleHits()
    {
        timesHit++;
        maxHits = hitSprites.Length + 1;

        if (timesHit >= maxHits)
        {
            DestroyBlock();
        }
        else
        {
            ShowDagmage();
        }
    }

    private void ShowDagmage()
    {
        spriteIndex = timesHit - 1;
        if(hitSprites[spriteIndex] != null)
        {
            PlaySoundEffects();
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Block sprites miss from the array in " + gameObject.name);
        }
    }

    private void DestroyBlock()
    {
        //Make a sound when a block is about to destroy
        PlaySoundEffects();

        //Destroy gameObject
        Destroy(gameObject);

        //Update Breakable Blocks
        level.BlockBreaked();

        //Update Score
        status.UpdateScore();

        //Applying Visual Effects
        TriggerSparklesVFX();

        //Random items
        SpawnItem();
    }

    private void PlaySoundEffects()
    {
        if( timesHit >= maxHits )
        {
            AudioSource.PlayClipAtPoint(blockSounds[0], Camera.main.transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(blockSounds[1], Camera.main.transform.position);
        }
        
    }
    
    private void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(blockSparklesVFX , transform.position , transform.rotation);
        Destroy(sparkles, 2f);
    }

    private void CountBreakableBlocks()
    {
        if (tag!="Unbreakable")
        {
            level = FindObjectOfType<Level>();
            level.CountBlocks();
        }


    }
    private void SpawnItem()
    {
        if (Random.Range(0 , 100) < itemSpawnPrabiblityPersent)
        {
            GameObject item = Instantiate(
                itemPrefab[Random.Range(0,itemPrefab.Length)],
                transform.position,
                Quaternion.identity);

            item.GetComponent<Rigidbody2D>().velocity =  new Vector2 (0, -(itemSpeed * Time.deltaTime));
        }
    }

}

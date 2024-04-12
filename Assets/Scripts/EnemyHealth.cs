using UnityEngine;

[RequireComponent(typeof(Enermy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    [Tooltip("Adds amount to maxHitPoints when enermy dies.")]
    [SerializeField] int difficultyRam = 1;
    int currentHitPoints = 0;

    Enermy enermy;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentHitPoints = maxHitPoints;
    }

    void Start()
    {
        enermy = GetComponent<Enermy>();
    }

    // Update is called once per frame
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        currentHitPoints--;

        if (currentHitPoints <= 0)
        {
            gameObject.SetActive(false);
            maxHitPoints += difficultyRam;
            enermy.ReWardGold();
        }
    }
}

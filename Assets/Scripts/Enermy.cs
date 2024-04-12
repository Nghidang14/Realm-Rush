using UnityEngine;

public class Enermy : MonoBehaviour
{
    [SerializeField] int goldReward = 25;
    [SerializeField] int goldPenalty = 25;

    Bank bank;

    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void ReWardGold()
    {
        if (bank == null)
        { return; }
        bank.Deposit(goldReward);
    }
    public void StealGold()
    {
        if (bank == null)
        { return; }
        bank.Withdraw(goldPenalty);
    }
}

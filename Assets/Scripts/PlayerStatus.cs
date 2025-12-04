using UnityEngine;
using UnityEngine.UI;
public class PlayerStatus : MonoBehaviour
{
    [SerializeField] int MaxHp = 20;
    [SerializeField] private Slider hpSlider;
    [SerializeField] Text currentHPUI;
    public int currentHp;

    private void Awake()
    {
        currentHp = MaxHp;
        if(hpSlider != null)
        {
            hpSlider.maxValue = MaxHp;
            UpdateUI();
        }
    }

    public void TakeDamage(int amount)
    {
        currentHp -= amount;
        if (currentHp < 0) currentHp = 0;

        Debug.Log($"Player took {amount} damage! Current Hp : {currentHp}");

        UpdateUI();

        if(currentHp <= 0)
        {
            Debug.Log("Player is dead!");

            // Proceed to BattleLoseState


        }
    }

    public void Heal(int amount)
    {
        currentHp += amount;
        if (currentHp > MaxHp) currentHp = MaxHp;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (hpSlider != null) hpSlider.value = currentHp;
        if (currentHPUI != null) currentHPUI.text = currentHp.ToString();

    }
}

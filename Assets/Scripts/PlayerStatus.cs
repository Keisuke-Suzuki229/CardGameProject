using UnityEngine;
using UnityEngine.UI;
public class PlayerStatus : MonoBehaviour
{
    [SerializeField] int MaxHp = 20;
    [SerializeField] private Slider hpSlider;
    [SerializeField] Text currentHPUI;
    public int currentHp;

    [Header("Shield UI")]
    [SerializeField] Image shieldUI;
    [SerializeField] Text shieldText;

    
    public int shield;

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
        int reduced = amount;
        if(shield > 0)
        {
            int used = Mathf.Min(shield, reduced);
            shield -= used;
            reduced -= used;
        }

        currentHp -= reduced;

        if (currentHp < 0) currentHp = 0;

        Debug.Log($"Player took {amount} damage! Current Hp : {currentHp}");

        UpdateUI();

        if(currentHp <= 0)
        {
            Debug.Log("Player is dead!");

            // Proceed to BattleLoseState


        }
    }

    public void AddShield(int amount)
    {
        shield += amount;
        UpdateUI();
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

        if(shield > 0)
        {
            shieldUI.gameObject.SetActive(true);
            shieldText.text = shield.ToString();

        }
        else
        {
            shieldUI.gameObject.SetActive(false);
        }

    }
}

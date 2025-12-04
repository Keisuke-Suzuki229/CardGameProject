using UnityEngine;
using UnityEngine.UI;
public class EnemyStatus : MonoBehaviour
{
    [SerializeField] int MaxHp = 20;
    [SerializeField] Slider hpSlider;
    [SerializeField] Text currentHPUI;
    

    public int currentHp;

    private void Awake()
    {
        currentHp = MaxHp;
        if (hpSlider != null)
        {
            hpSlider.maxValue = MaxHp;

        }
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        currentHp -= amount;
        if (currentHp < 0) currentHp = 0;

        Debug.Log($"Enemy took {amount} damage! current HP : {currentHp}");

        UpdateUI();

        if(currentHp <= 0)
        {
            Debug.Log("Enemy is dead");
            Destroy(gameObject);
            //proceed to winState
        }
    }

    void UpdateUI()
    {
        if(hpSlider != null)
        {
            hpSlider.value = currentHp;
        }
        if (currentHPUI != null) currentHPUI.text = currentHp.ToString();
    }
}

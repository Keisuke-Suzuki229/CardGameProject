using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class Mana : MonoBehaviour
{
    [SerializeField] int maxMana = 5;
    [SerializeField] int currentMana;

    [SerializeField] Text manaText;

    private void Start()
    {
        ResetMana();
    }

    public void ResetMana()
    {
        currentMana = maxMana;
        UpdateManaUI();
    }

    public bool UseMana(int cost)
    {
        if(currentMana < cost)
        {
            Debug.Log("Not enough mana!");
            return false;
        }

        currentMana -= cost;
        UpdateManaUI();
        return true;
    }

    void UpdateManaUI()
    {
        if(manaText != null)
        {
            manaText.text = $"{currentMana}";
        }
    }
    public int GetCurrentMana() => currentMana;

}

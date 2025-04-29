using UnityEngine;
using UnityEngine.UI;

public class HealthBar_UI : MonoBehaviour
{
    private Entity entity;
    private CharacterStats myStats;
    private RectTransform myTransform;
    private Slider slider;

    private void Start()
    {
        myTransform = GetComponent<RectTransform>();
        entity = GetComponentInParent<Entity>();
        slider = GetComponentInChildren<Slider>();
        myStats = GetComponentInParent<CharacterStats>();

        if (entity == null || myStats == null || slider == null)
        {
            Debug.LogError("HealthBar_UI: Missing required components!");
            return;
        }

        entity.onFlipped += FlipUI;
        myStats.onHealthChanged += UpdateHealthUI;

        UpdateHealthUI();

    }

    private void UpdateHealthUI()
    {
        slider.maxValue = myStats.GetMaxHealthValue();
        slider.minValue = 0; 
        slider.value = myStats.currentHealth; 
        Debug.Log($"HealthBar_UI: Updated - Max: {slider.maxValue}, Current: {slider.value}");
    }

    private void FlipUI() => myTransform.Rotate(0, 180, 0);

    private void OnDisable()
    {
        if (entity != null)
            entity.onFlipped -= FlipUI;
        if (myStats != null)
            myStats.onHealthChanged -= UpdateHealthUI; 
    }
}
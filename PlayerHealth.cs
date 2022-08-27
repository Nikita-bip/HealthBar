using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;

    private int _countOfHealth = 10;
    private int _minCountOfHealth = 0;
    private void Start()
    {
        HealthBar.Health = HealthBar.MaxHealth;
    }

    public void Heal()
    {
        if(HealthBar.Health < HealthBar.MaxHealth)
            HealthBar.Health += _countOfHealth;
      
        _healthBar.value = HealthBar.Health;
    }
   
    public void Damage()
    {
        if (HealthBar.Health > _minCountOfHealth)
            HealthBar.Health -= _countOfHealth;
      
        _healthBar.value = HealthBar.Health;
    }
}
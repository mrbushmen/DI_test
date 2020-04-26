using UnityEngine;

/// <summary>
/// Герой
/// </summary>
public class Hero : MonoBehaviour
{
    private Weapon weapon;

    public void Init(Weapon weapon)
    {
        this.weapon = weapon;
    }

    public void Strike()
    {
        weapon.Strike();
    }
}

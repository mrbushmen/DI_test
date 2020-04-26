using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroFactory : MonoBehaviour
{
    [SerializeField]
    private GameObject heroPrefab;

    private Club club;
    private Sword sword;

    /// <summary>
    /// Спавнит префаб героя и возвращает ссылку на его класс
    /// </summary>
    /// <returns></returns>
    private Hero SpawnHero()
    {
        return Instantiate(heroPrefab).GetComponent<Hero>();
    }

    public Hero MakeSwordman()
    {
        //Нужно создать экземлер класса, иначе weapon в Hero будет null.
        //Т.к. Sword не является MonoBehaviour, нет необходимости создавать его на сцене, достаточно оператора new
        sword = new Sword();

        var hero = SpawnHero();
        hero.Init(sword);

        //Можно было и не делать, чисто для наглядности на сцене:
        hero.gameObject.name = "Swordman";

        Debug.Log("Мечник создан");
        return hero;
    }

    public Hero MakeClubman()
    {
        club = new Club();

        var hero = SpawnHero();
        hero.Init(club);


        hero.gameObject.name = "Clubman";

        Debug.Log("Чувак с дубиной создан");
        return hero;
    }
}

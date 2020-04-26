using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private HeroFactory heroFactory;
    private Hero hero;

    private void Start()
    {
        Debug.Log("====  S и С - создание героя. A - атака  ====");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            hero = heroFactory.MakeClubman();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            hero = heroFactory.MakeSwordman();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (hero)
                hero.Strike();
            else
                Debug.LogError("Сначала создай героя");
        }
    }
}

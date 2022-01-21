using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BattleState { START, P1, P2, P3, E1, E2, E3, WON, LOST }

public class FightManager : MonoBehaviour
{
    public GameObject p1Prefab;
    public GameObject p2Prefab;
    public GameObject p3Prefab;

    public GameObject e1Prefab;
    public GameObject e2Prefab;
    public GameObject e3Prefab;

    public BattleState state;

    void Start()
    {
        state = BattleState.START;
        SetupBattle();
    }

    void SetupBattle()
    {

    }
}

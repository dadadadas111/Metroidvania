using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponScriptableObject", menuName = "ScriptableObjects/Weapon", order = 1)]
public class WeaponScriptableObject : ScriptableObject
{
    // properties
    [SerializeField]
    GameObject _prefab;
    [SerializeField]
    float _damage;
    [SerializeField]
    float _speed;
    [SerializeField]
    float _cooldownDuration;
    [SerializeField]
    int _pierce;

    // getters and setters
    public GameObject Prefab { get => _prefab; private set => _prefab = value; }
    public float Damage { get => _damage; private set => _damage = value; }
    public float Speed { get => _speed; private set => _speed = value; }
    public float CooldownDuration { get => _cooldownDuration; private set => _cooldownDuration = value; }
    public int Pierce { get => _pierce; private set => _pierce = value; }

}

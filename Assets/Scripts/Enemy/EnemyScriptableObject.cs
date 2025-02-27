using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyScriptableObject", menuName = "ScriptableObjects/Enemy")]
public class EnemyScriptableObject : ScriptableObject
{
    // properties
    [SerializeField]
    float _maxHealth;
    [SerializeField]
    float _moveSpeed;
    [SerializeField]
    float _damage;
    [SerializeField]
    float _attackCooldown;
    [SerializeField]
    float _attackRange;
    [SerializeField]
    float _attackDuration;
    [SerializeField]
    float _attackDelay;
    [SerializeField]
    float _attackDamage;
    [SerializeField]
    float _attackSpeed;


    // getters and setters
    public float MaxHealth { get => _maxHealth; private set => _maxHealth = value; }
    public float MoveSpeed { get => _moveSpeed; private set => _moveSpeed = value; }
    public float Damage { get => _damage; private set => _damage = value; }
    public float AttackCooldown { get => _attackCooldown; private set => _attackCooldown = value; }
    public float AttackRange { get => _attackRange; private set => _attackRange = value; }
    public float AttackDuration { get => _attackDuration; private set => _attackDuration = value; }
    public float AttackDelay { get => _attackDelay; private set => _attackDelay = value; }
    public float AttackDamage { get => _attackDamage; private set => _attackDamage = value; }
    public float AttackSpeed { get => _attackSpeed; private set => _attackSpeed = value; }
}

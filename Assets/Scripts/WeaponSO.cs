using UnityEngine;
using UnityEngine.Rendering;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "ScriptableObjects/WeaponSO")]
public class WeaponSO : ScriptableObject
{
    public GameObject WeaponPrefab;
    public int Damage = 1;
    public float FireRate = .5f;
    public GameObject HitVFXPrefab;
    public bool IsAutomatic = false;
    public bool CanZoom = false;
}
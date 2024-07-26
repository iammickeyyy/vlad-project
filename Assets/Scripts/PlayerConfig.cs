using UnityEngine;

[CreateAssetMenu(fileName = "Player Config", menuName = "Configs/Player")]
public class PlayerConfig : ScriptableObject
{
    public float PlayerShootDelay;
    public float MoveSpeed;
}
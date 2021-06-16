using UnityEngine;

public enum Direction
{
    NONE,
    DOWN,
    UP,
}

public class Elevator : MonoBehaviour
{
    public Direction Direction;
    public int Floor;
}

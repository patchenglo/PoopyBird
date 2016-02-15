using UnityEngine;
using System.Collections;

public class PingCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Terrain")
        {
            print("touched terrain");
        } else if (col.gameObject.name == "suitF01")
        {
            print("touched the man");

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoods : MonoBehaviour
{
    [SerializeField] Rigidbody[] goods;
    
    public void MovingGoods()
    {
        foreach (var good in goods)
        {
            good.AddForce(Vector3.forward * 0.5f, ForceMode.Impulse);
        }
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGoods : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out SuperMarketGoods _superMarketGoods))
        {
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z + 0.1f);

        }
    }
}

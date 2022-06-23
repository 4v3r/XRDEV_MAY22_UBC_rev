using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour
{
    public void DestroyFoodItem()
    {
        Destroy(gameObject, 5.0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/SpawnBehavoir")]
public class SpanwBehavoir : ScriptableObject
{
   public Vector3DataList vector3DataListObj;
   public GameObject prefab;
   public int num = 1;
 
      public void CreateIncstanceFromListRandomly(Vector3DataList obj)
      {
         num = Random.Range(0, obj.vector3List.Count - 1);
         Instantiate(prefab, obj.vector3List[num].value, Quaternion.identity);
      
      }

      public void IncreaseSpawnAmount(int value)
      {
         
         num = value;
         
      }
 
}

using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Atar.Authoring
{
    [DisallowMultipleComponent]
    public class TowerListAuthoring : MonoBehaviour, IConvertGameObjectToEntity
    {
        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
        {
        }
    }
}


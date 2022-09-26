using Latios;
using Latios.Systems;
using Unity.Entities;

namespace Atar
{
    [UpdateInGroup(typeof(LatiosWorldSyncGroup))]
    public class SyncPointRootSuperSystem : RootSuperSystem
    {
        protected override void CreateSystems()
        {
        }
    }

    [UpdateInGroup(typeof(PresentationSystemGroup))]
    [UpdateBefore(typeof(Unity.Rendering.StructuralChangePresentationSystemGroup))]
    public class PresentationRootSuperSystem : RootSuperSystem
    {
        protected override void CreateSystems()
        {
        }
    }

    [UpdateInGroup(typeof(SimulationSystemGroup))]
    [UpdateBefore(typeof(Unity.Transforms.TransformSystemGroup))]
    public class PreTransformSimulationRootSuperSystem : RootSuperSystem
    {
        protected override void CreateSystems()
        {
        }
    }

    [UpdateInGroup(typeof(SimulationSystemGroup))]
    [UpdateAfter(typeof(Unity.Transforms.TransformSystemGroup))]
    public class PostTransformSimulationRootSuperSystem : RootSuperSystem
    {
        protected override void CreateSystems()
        {
        }
    }
}


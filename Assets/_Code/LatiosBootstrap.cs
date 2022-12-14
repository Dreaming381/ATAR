using System;
using System.Collections.Generic;
using Latios;
using Latios.Authoring;
using Unity.Entities;

namespace Atar.Authoring
{
    [UnityEngine.Scripting.Preserve]
    public class LatiosConversionBootstrap : ICustomConversionBootstrap
    {
        public bool InitializeConversion(World conversionWorldWithGroupsAndMappingSystems, CustomConversionSettings settings, ref List<Type> filteredSystems)
        {
            var defaultGroup = conversionWorldWithGroupsAndMappingSystems.GetExistingSystem<GameObjectConversionGroup>();
            BootstrapTools.InjectSystems(filteredSystems, conversionWorldWithGroupsAndMappingSystems, defaultGroup);

            Latios.Psyshock.Authoring.PsyshockConversionBootstrap.InstallLegacyColliderConversion(conversionWorldWithGroupsAndMappingSystems);
            Latios.Kinemation.Authoring.KinemationConversionBootstrap.InstallKinemationConversion(conversionWorldWithGroupsAndMappingSystems);
            return true;
        }
    }
}

namespace Atar
{
    [UnityEngine.Scripting.Preserve]
    public class LatiosBootstrap : ICustomBootstrap
    {
        public unsafe bool Initialize(string defaultWorldName)
        {
            var world                             = new LatiosWorld(defaultWorldName);
            World.DefaultGameObjectInjectionWorld = world;
            world.useExplicitSystemOrdering       = true;

            var systems = new List<Type>(DefaultWorldInitialization.GetAllSystems(WorldSystemFilterFlags.Default));

            BootstrapTools.InjectUnitySystems(systems, world, world.simulationSystemGroup);
            BootstrapTools.InjectRootSuperSystems(systems, world, world.simulationSystemGroup);

            world.GetExistingSystem<Unity.Transforms.CopyInitialTransformFromGameObjectSystem>().Enabled = false;  // Leaks LocalToWorld query and generates ECB.

            CoreBootstrap.InstallSceneManager(world);
            CoreBootstrap.InstallExtremeTransforms(world);
            Latios.Myri.MyriBootstrap.InstallMyri(world);
            Latios.Kinemation.KinemationBootstrap.InstallKinemation(world);

            world.initializationSystemGroup.SortSystems();
            world.simulationSystemGroup.SortSystems();
            world.presentationSystemGroup.SortSystems();

            BootstrapTools.AddWorldToCurrentPlayerLoopWithDelayedSimulation(world);
            return true;
        }
    }
}


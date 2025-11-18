using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MiniIT.Installers
{
    [CreateAssetMenu(fileName = "Configs Installer", menuName = "Data/Installers/Configs Installer")]
    public class ConfigsInstaller : ScriptableObjectInstaller<ConfigsInstaller>
    {
        [SerializeField] private List<ScriptableObject> _scriptableObjects;
    
        public override void InstallBindings()
        {
            Container.Bind<ConfigsInstaller>().AsSingle();

            foreach (var scriptable in _scriptableObjects)
            {
                Container.QueueForInject(scriptable);
                Container.Bind(scriptable.GetType()).FromInstance(scriptable).AsSingle();
            }
        }
    }
}
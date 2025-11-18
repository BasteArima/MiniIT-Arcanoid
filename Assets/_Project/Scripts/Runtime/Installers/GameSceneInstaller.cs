using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace MiniIT.Installers
{
    public class GameSceneInstaller : MonoInstaller
    {
        [SerializeField] private List<string> _someList = null;
        
        public override void InstallBindings()
        {
            
        }
    }
}
using System;
using Test123.Test1.Core.Installer;
using Test123.Test1.UI;
using Test123.Test1.UI.Model;
using UnityEngine;
using UnityEngine.UIElements;
using Zenject;

namespace Test123.Test1.Installers
{
    public class GameSceneInstaller : MonoInstaller<GameSceneInstaller>
    {
        [SerializeField] 
        private UIDocument _mainUIDocument;

        private MainUIViewModel _mainUIViewModel;

        private void Awake()
        {
            _mainUIViewModel = new MainUIViewModel(new MainModel(), _mainUIDocument);
        }

        public override void InstallBindings()
        {
            CoreInstaller.Install(Container);
        }
    }
}
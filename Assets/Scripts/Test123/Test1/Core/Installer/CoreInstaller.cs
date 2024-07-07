using Test123.Test1.Core.Cities.Controller;
using Zenject;

namespace Test123.Test1.Core.Installer
{
    public class CoreInstaller: Installer<CoreInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<CityController>().AsSingle().NonLazy();
        }
    }
}
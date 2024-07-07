using System;
using Test123.Test1.Core.StaticData;
using Test123.Test1.UI.Model;
using Unity.Properties;
using UnityEngine.UIElements;

namespace Test123.Test1.UI
{
    public class MainUIViewModel : ViewModel<MainModel>
    {
        private ListView _listView;
        
        public MainUIViewModel(MainModel data, UIDocument targetDocument) : base(data, targetDocument)
        {
            TextField textField = targetDocument.rootVisualElement.Q<TextField>("XTextField");
            _listView = targetDocument.rootVisualElement.Q<ListView>("ListView");

            textField.SetBinding("value", new DataBinding()
            {
                bindingMode = BindingMode.ToSource,
                dataSourcePath = PropertyPath.FromName(nameof(MainModel.MainValue)),
                dataSource = Data,
            });
            
            Label label = targetDocument.rootVisualElement.Q<Label>("TestLabel");
            
            label.SetBinding("value", new DataBinding()
            {
                bindingMode = BindingMode.ToTarget,
                dataSourcePath = PropertyPath.FromName(nameof(MainModel.MainValue)),
                dataSource = Data,
            });

            PopulateListView();
        }

        public void PopulateListView()
        {
            Func<VisualElement> makeItem = () => _listView.itemTemplate.Instantiate();
            Action<VisualElement, int> bindItem = (e, i) => e.Q<Button>("Button").text = StaticDataContainer.cities[i].name;
            _listView.makeItem = makeItem;
            _listView.bindItem = bindItem;
            _listView.itemsSource = StaticDataContainer.cities;
            _listView.selectionType = SelectionType.Multiple;
        }
    }
}
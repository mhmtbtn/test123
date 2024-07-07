using System;
using Test123.Test1.UI;
using Test123.Test1.UI.Model;
using UnityEngine;
using UnityEngine.UIElements;

namespace UI
{
    public class Test : MonoBehaviour
    {
        [SerializeField] 
        private UIDocument _document;

        private MainUIViewModel _mainUIViewModel;
        
        private void Awake()
        {
            _mainUIViewModel = new MainUIViewModel(new MainModel(), _document);
        }
    }
}
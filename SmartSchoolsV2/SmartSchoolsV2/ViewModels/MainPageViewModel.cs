﻿using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSchoolsV2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public float Radius { get; set; }
        public float Percentage { get; set; }

        public List<string> Items { get; set; } = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5",
            "Item 6"
        };

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}

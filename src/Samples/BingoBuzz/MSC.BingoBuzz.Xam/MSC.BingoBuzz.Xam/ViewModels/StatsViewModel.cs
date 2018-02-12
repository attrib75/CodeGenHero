﻿using GalaSoft.MvvmLight;
using MSC.BingoBuzz.Xam.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MSC.BingoBuzz.Xam.ViewModels
{
    public class StatsViewModel : CustomViewModelBase
    {
        public StatsViewModel(INavigationService navService, IDataService dataService) : base(navService, dataService)
        {
        }

        public override async Task Init()
        {
        }
    }
}
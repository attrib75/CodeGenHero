﻿using CodeGenHero.BingoBuzz.Interfaces;
using CodeGenHero.BingoBuzz.Xam.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CodeGenHero.BingoBuzz.Xam.Interfaces
{
    public interface INavigationService
    {
        event PropertyChangedEventHandler CanGoBackChanged;

        bool CanGoBack { get; }

        Page GetCurrentView();

        Page GetLastView();

        CustomViewModelBase GetViewModel(Type viewModelType);

        Task GoBack();

        Task NavigateTo<TVM>() where TVM : IViewModelBase;

        Task NavigateTo<TVM, TParameter>(TParameter parameter) where TVM : IViewModelBaseWithParam<TParameter>;

        Task NavigateToNoAnimation<TVM>() where TVM : IViewModelBase;

        Task NavigateToNoAnimation<TVM, TParameter>(TParameter parameter) where TVM : IViewModelBaseWithParam<TParameter>;

        Task NavigateToUri(Uri uri);

        Task PopActivityIndicatorTransparentPopupsAsync();

        Task PopAlertPopupsAsync();

        Task PopPopupAsync();

        Task PopToRoot();

        Task PushActivityIndicatorTransparentPopupAsync();

        Task PushAlertPopupAsync(string message);

        Task PushBingoPopupAsync();

        void RemoveDuplicatePageByType(Type pageType);

        void RemoveLastView();

        void RemovePageByType(Type pageType);

        Task StartNavStack(Type pageType);
    }
}
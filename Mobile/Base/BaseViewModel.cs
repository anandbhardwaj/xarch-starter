﻿using Common;
using Definition.Interfaces;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;

namespace Mobile.ViewModel
{
    public class BaseViewModel : ViewModelBase
    {
        protected AsyncLock _lock = new AsyncLock();
        
        public BaseViewModel() { }
        
        public BaseViewModel(GalaSoft.MvvmLight.Messaging.IMessenger messenger) : base(messenger) { }

        public virtual void Subscribe() { }

        public virtual void OnAppearing() { }

        public virtual void OnDisappearing() { }
      
        protected IExtNavigationService NavigationService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IExtNavigationService>();
            }
        }

        protected IDialogService DialogService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IDialogService>();
            }
        }

    }
}

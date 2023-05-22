﻿using Data;
using Presentation.WPF.Model.API;
using Presentation.WPF.Model.CodeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Presentation.WPF.ViewModel
{
    internal class ViewModelMain : VMBase
    {
        //private readonly IModel ?model;
        private IEnumerable<ICatalogModelData> catalogList;
        private ICommand? Command1 { get; set; }
        private ICommand _SwitchViewCommand;
        private VMBase _selectedVm;

        public ViewModelMain()
        {
            //catalogList = model.GetCatalogsList();
            catalogList = new List<ICatalogModelData>
            {
                new CatalogModelData(1,"Raj",100),
                new CatalogModelData(2,"AAAAAAAAAAAA",100),
                new CatalogModelData(3,"BBBBBBBB",100),
                new CatalogModelData(4,"CCCCCCCC",200),
               
            };

        }

        public VMBase SelectedVm
        {
            get => _selectedVm;
            set
            {
                _selectedVm = value;
                OnPropertyChanged(nameof(SelectedVm));
            }
        }

        public IEnumerable<ICatalogModelData> Catalogs
        {
            get { return catalogList; }
            set { catalogList = value; }
        }

        public ICommand SwitchViewCommand => _SwitchViewCommand;

        public void SwitchView(string view)
        {
            switch (view)
            {
                case "ProductListView":
                    SelectedVm = new VMCatalogList();
                    break;
            }
        }


        /*public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }*/

        /*private class Updater : ICommand
        {
            public bool CanExecute(object? parameter)
            {
                return true;
            }

            public event EventHandler? CanExecuteChanged;

            public void Execute(object? parameter)
            {

            }

        }*/
    }
}

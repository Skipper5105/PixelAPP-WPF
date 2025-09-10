using PixelWPF.Kernel;
using PixelWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelWPF.ViewModels
{
    internal class MainViewModels : ObservalObject
    {

        // Commands
            public RelayCommands VerkaufViewCommand { get; set; }
            public RelayCommands DienstleistungenViewCommand { get; set; }
            public RelayCommands KaufViewCommand { get; set; }

        // ViewModels
            public VerkaufViewModel VerkaufVM{ get; set; }
            public DienstleistungenViewModel DienstleistungenVM { get; set; }

            public KaufViewModels KaufVM { get; set; }

            private object _currentView;
            public object CurrentView
            {
                get { return _currentView; }
                set
                {
                    _currentView = value;
                    OnPropertyChanged();
                }

            }



          public MainViewModels()
          {
                VerkaufVM = new VerkaufViewModel();
                DienstleistungenVM = new DienstleistungenViewModel();
                KaufVM = new KaufViewModels();
                CurrentView = DienstleistungenVM;

                VerkaufViewCommand = new RelayCommands(o =>
                {
                    CurrentView = VerkaufVM;
                });

                DienstleistungenViewCommand = new RelayCommands(o =>
                {
                    CurrentView = DienstleistungenVM;
                });

                KaufViewCommand = new RelayCommands(o =>
                {
                    CurrentView = KaufVM;
                });

        } 
        
    }
}

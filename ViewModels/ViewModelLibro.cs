using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BibliotecaLibros.ViewModels
{
    public class ViewModelLibro: INotifyPropertyChanged
    {

        string nombre;

        public string Nombre
        {
            get => nombre;

            set
            {
                nombre = value;

                var arg = new PropertyChangedEventArgs(nameof(Nombre));

                PropertyChanged?.Invoke(this, arg);

            }


        }


        string autor;

        public string Autor 
        { 
        
            get => autor;

            set
            {
                autor = value;
                var arg = new PropertyChangedEventArgs(nameof(Autor));

                PropertyChanged?.Invoke(this, arg);

            }

        }


        DateTime fechaImpresion;
        public DateTime FechaImpresion 
        {
            get => fechaImpresion;

            set
            {
                fechaImpresion = value;
                var arg = new PropertyChangedEventArgs(nameof(FechaImpresion));

                PropertyChanged?.Invoke(this, arg);
            }
            
        
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

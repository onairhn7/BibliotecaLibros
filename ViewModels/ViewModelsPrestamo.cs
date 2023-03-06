using BibliotecaLibros.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BibliotecaLibros.ViewModels
{
    public class ViewModelsPrestamo: INotifyPropertyChanged
    {

        Libros libros;
        public Libros Libros
        {
            get => libros;

            set
            {

                libros = value;
                var arg = new PropertyChangedEventArgs(nameof(Libros));

                PropertyChanged?.Invoke(this, arg);
            }
        }


        Persona persona;

        public Persona Persona
        {
            get => persona;

            set
            {
                persona = value;
                var arg = new PropertyChangedEventArgs(nameof(Persona));

                PropertyChanged?.Invoke(this, arg);
            }
        }


        DateTime fechaPresamo;
        public DateTime FechaPresamo
        {

            get => fechaPresamo;

            set
            {

                fechaPresamo = value;
                var arg = new PropertyChangedEventArgs(nameof(FechaPresamo));

                PropertyChanged?.Invoke(this, arg);
            }
        }


        DateTime fechaDevolucion;

        public DateTime FechaDevolucion
        {

            get => fechaDevolucion;

            set
            {

                fechaDevolucion = value;
                var arg = new PropertyChangedEventArgs(nameof(FechaDevolucion));

                PropertyChanged?.Invoke(this, arg);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

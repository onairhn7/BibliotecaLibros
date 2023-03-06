using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using BibliotecaLibros.Models;
using System.Collections.ObjectModel;

namespace BibliotecaLibros.ViewModels
{
    public class ViewModelPersona: INotifyPropertyChanged
    {


        public ViewModelPersona()
        {
            // Esta es la inicializacion de lista de personas que creamos abajo

            ListaPersonas = new ObservableCollection<Persona>();

            CrearPersona = new Command(() =>
            {
                Persona p = new Persona()
                {
                    // aqui le estamos diciendo que la propiedades de la clase persona sean iguales a las propiedades privadas del viewmodels
                    nombre= this.nombre,
                    numeroCuenta= this.numeroCuenta,

                };

                listaPersonas.Add(p);

            });

        }

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


        string numeroCuenta;
        public string NumeroCuenta
        {

            get => numeroCuenta;

            set
            {
                numeroCuenta = value;
                var arg = new PropertyChangedEventArgs(nameof(NumeroCuenta));

                PropertyChanged?.Invoke(this, arg);

            }
        }
        // En lugar de hacer una lista persona se hace esto que es equivalente ademas se debe hacer uno privado y otro publico
         ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();

        public ObservableCollection<Persona> ListaPersonas
        {
            get => listaPersonas;

            set { 
                
                listaPersonas = value;

            
                var arg = new PropertyChangedEventArgs(nameof(ListaPersonas));

                PropertyChanged?.Invoke(this, arg);


            }
        }

        public Command CrearPersona { get; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

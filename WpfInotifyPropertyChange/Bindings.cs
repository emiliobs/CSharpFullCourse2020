using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfInotifyPropertyChange
{
    public class Bindings : PropertyChangedClass 
    {
        private string _nombre;
        private string _apellidos;
        private string _nombreCompleto;

        public Bindings(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }

        public string Nombre 
        { 
            get => _nombre;
            set
            {
                if (_nombre != value)
                {
                    _nombre = value;
                    OnPropertychange("NombreCompleto"); 
                }
            }
        }
        public string Apellidos 
        { 
            get => _apellidos;
            set
            {
                if (_apellidos != value)
                {
                    _apellidos = value;
                    OnPropertychange("NombreCompleto");
                }
            }
        }
        public string NombreCompleto
        {
            get => _nombreCompleto = $"{Nombre} {Apellidos}";
            //set
            //{
            //    if (_nombreCompleto != value)
            //    {
            //        _nombreCompleto = value;
            //        OnPropertychange();
            //    }

            //}
        }
    }
}

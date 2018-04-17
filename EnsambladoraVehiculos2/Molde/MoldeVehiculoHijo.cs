﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeVehiculoHijo : MoldeVehicoPadre
    {
        #region Constructores

        public MoldeVehiculoHijo()
        {

        }
        public MoldeVehiculoHijo(int _numPuertas, int _numllantas, string _color, string _marca)
        {
            NumPuertas = _numPuertas;
            NumLlantas = _numllantas;
            Color = _color;
            Marca = _marca;
        }

        public MoldeVehiculoHijo(int _numPuertas, int _numllantas, string _marca)
        {
            NumPuertas = _numPuertas;
            NumLlantas = _numllantas;
            Marca = _marca;
        }
        #endregion

        #region Propiedades

        /// <summary>
        /// esta propiedad me guarda el numero de puertas que va tener el carrio
        /// </summary>
        public int NumPuertas { get; set; }
        #endregion

        #region Metodos

        /// <summary>
        /// este metodo me controla la velocidad cuando acelera
        /// </summary>
        /// <param name="_presionPedalAcelerar"></param>
        public void Acelerar(int _presionPedalAcelerar)
        {
            if (_presionPedalAcelerar > 0)
                Velocidad = _presionPedalAcelerar * 2;

            Velocidad = 0;
        }

        #endregion
    }
}

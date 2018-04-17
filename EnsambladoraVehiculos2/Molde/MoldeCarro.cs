using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnsambladoraVehiculos2.Molde
{
    public class MoldeCarro : MoldeVehiculoHijo
    {

        public MoldeCarro(int _numPuertas, int _numllantas, string _color, string _marca)
            :base (_numPuertas, _numllantas, _color, _marca)
        {
        }

        public MoldeCarro(int _numPuertas, int _numllantas, string _marca)
            : base(_numPuertas, _numllantas, _marca)
        {
           
        }

        #region Propiedades


        #endregion

        #region Metodos

        /// <summary>
        /// esta funcion me permite que mi vehiculo de reversa
        /// </summary>
        /// <param name="_presionPedalAcelerar"></param>
        public void Reversa(int _presionPedalAcelerar)
        {
            if (_presionPedalAcelerar > 0)
                Velocidad = _presionPedalAcelerar * 2;

            Velocidad = 0;
        } 
        #endregion
    }
}

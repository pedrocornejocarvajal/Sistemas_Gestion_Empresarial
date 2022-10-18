﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class clsManejadoraPersonaDAL
    {
        /// <summary>
        /// Accedemos a la base de datos y devlvemos la persona cuyo id corresponda con el parametro de entrada
        /// Precondiciones: El id introducido debe existir en la base de datos
        /// Postcondiciones: La persona nunca se manda vacía
        /// </summary>
        /// <param name="id"></param>
        /// <returns> clsPersona </returns>
        public clsPersona obtenerPersonasPorID(int id)
        {
            return new clsPersona();
        }


        /// <summary>
        /// Actualiza o guarda una persona en la base de datos
        /// Precondiciones: ninguna
        /// Postcondiciones: Numero de filas afectadas es mayor o igual a 0
        /// </summary>
        /// <param name="persona"></param>
        /// <returns></returns>
        public int guardarPersona(clsPersona persona)
        {
            int numFilasAfectadas=0;
            ///codigo 
            return numFilasAfectadas;
        }
    }
}

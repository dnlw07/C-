using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // Typy wyliczoeniowe enum są składowane w klasie o nazwie enum
    class Enums
    {
        // Typ wyliczeniowy enum
        public enum Days
        {
            // lista wyliczeniowa - pola wewnątrze enum
            // element wyliczeniowy - pojedyczne pole w enum (domyślnym typem zmiennej jest int)
            Monday,
            Tuedday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public enum Score:long
        {
            Winner = 25000000000,
            Looser = 100
        }
    }
}

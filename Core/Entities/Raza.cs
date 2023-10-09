using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Raza : BaseEntity
    {
        public string NombreRaza { get; set; }
        ICollection<Mascota> Mascotas { get; set; }
    }

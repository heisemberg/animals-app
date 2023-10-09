using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Ciudad : BaseEntity
{
    public string NombreCiudad { get; set; }
    public int IdDep { get; set; }
    public Departamento Departamentos { get; set; }
    public ICollection<ClienteDireccion> ClienteDireccions { get; set; }
}

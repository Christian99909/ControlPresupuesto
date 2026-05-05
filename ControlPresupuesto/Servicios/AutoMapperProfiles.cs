using AutoMapper;
using ControlPresupuesto.Models;

namespace ControlPresupuesto.Servicios
{
    public class AutoMapperProfiles: Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Cuenta, CuentaCreacionViewModel>();
        }


    }
}

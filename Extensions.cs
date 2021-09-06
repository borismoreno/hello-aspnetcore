using HelloAspNetCore.Dtos;
using HelloAspNetCore.Entities;

namespace HelloAspNetCore
{
    public static class Extensions
    {
        public static ClienteDto AsDto(this Cliente cliente)
        {
            return new ClienteDto(
                cliente.Id, 
                cliente.razonSocial, 
                cliente.numeroIdentificacion, 
                cliente.telefono, 
                cliente.mail, 
                cliente.activo, 
                cliente.tipoIdentificacion, 
                cliente.direccion, 
                cliente.usuario, 
                cliente.fechaModificacion
            );
        }
    }
}
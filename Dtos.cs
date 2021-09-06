using System;
using MongoDB.Bson;

namespace HelloAspNetCore.Dtos
{
    public record ClienteDto(
        ObjectId Id, 
        string razonSocial, 
        string numeroIdentificacion, 
        string telefono, 
        string mail, 
        bool activo,
        ObjectId tipoIdentificacion,
        string direccion,
        ObjectId usuario,
        DateTime fechaModificacion
    );
}
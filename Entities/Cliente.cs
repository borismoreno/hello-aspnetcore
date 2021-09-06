using System;
using MongoDB.Bson;

namespace HelloAspNetCore.Entities
{
    public class Cliente
    {

        public ObjectId Id { get; set; }

        public string razonSocial { get; set; }

        public string numeroIdentificacion { get; set; }

        public string telefono { get; set; }

        public string mail { get; set; }

        public bool activo { get; set; }

        public ObjectId tipoIdentificacion { get; set; }

        public string direccion { get; set; }

        public ObjectId usuario { get; set; }

        public DateTime fechaModificacion { get; set; }

        public int __v { get; set; }
    }
}
using ApiWebDB.BaseDados.Models;
using ApiWebDB.Services.DTOs;
using ApiWebDB.Services.Exceptions;
using System;

namespace ApiWebDB.Services.Validate
{
    public class ClienteValidate
    {
        private static bool ValidateDocument(TipoDocumento tipo, string documento)
        {
            switch (tipo)
            {
                case TipoDocumento.CPF:
                    if (documento.Length != 11)
                        throw new BadRequestExceptions("Campo CPF precisa ter 11 digitos");
                    return true;
                case TipoDocumento.CNPJ:
                    if (documento.Length != 14)
                        throw new BadRequestExceptions("Campo CNPJ precisa ter 14 digitos");
                    return true;
                case TipoDocumento.Passaporte:
                    if (documento.Length != 8)
                        throw new BadRequestExceptions("Campo Passaporte precisa ter 8 digitos");
                    return true;
                case TipoDocumento.CNH:
                    if (documento.Length != 11)
                        throw new BadRequestExceptions("Campo precisa ter 11 registros");
                    return true;
                default:
                    return true;
            }
        }
        public static bool Execute(ClienteDTO dto)
        {
            if (string.IsNullOrEmpty(dto.Nome))
                throw new InvalidEntityExceptions("Campo nome é obrigatório");

            if (string.IsNullOrEmpty(dto.Documento))
                throw new InvalidEntityExceptions("Documento nome é obrigatório");

            if (dto.Tipodoc <= 0)
                throw new InvalidEntityExceptions("Campo tipo de documento não pode ser nulo");

            TipoDocumento tipo;
            try
            {
                tipo = (TipoDocumento)dto.Tipodoc;
            }
            catch
            {
                throw new InvalidEntityExceptions($"O TipoDoc {dto.Tipodoc} é inválido.");
            }
            return ValidateDocument(tipo, dto.Documento);
        }
    }
}
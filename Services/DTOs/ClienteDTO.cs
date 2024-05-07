using System;

namespace ApiWebDB.Services.DTOs
{
    public class ClienteDTO
    {
        /// <example>
        /// Juca
        /// </example>
        public string Nome { get; set; }
        /// <example>
        /// 2003-02-06
        /// </example>
        public DateOnly? Nascimento { get; set; }
        /// <example>
        /// 49988348013
        /// </example>
        public string Telefone { get; set; }
        /// <example>
        /// 11777831938
        /// </example>
        public string Documento { get; set; }
        /// <summary>
        /// 0 - CPF 1 - CNPJ 2 - Passaporte 3 - CNH 99 - Outros
        /// </summary>
        /// <example>
        /// 1
        /// </example>
        public int Tipodoc { get; set; }
    }
}

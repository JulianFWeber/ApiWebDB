namespace ApiWebDB.Services.DTOs
{
    public class EnderecoDTO
    {
        /// <example>
        /// 89868000
        /// </example>
        public int Cep { get; set; }
        /// <example>
        /// Rua Rodolfo Foss
        /// </example>
        public string Logradouro { get; set; }
        /// <example>
        /// 1396
        /// </example>
        public string Numero { get; set; }
        /// <example>
        /// Casa
        /// </example>
        public string Complemento { get; set; }
        /// <example>
        /// Belvedere
        /// </example>
        public string Bairro { get; set; }
        /// <example>
        /// Saudades
        /// </example>
        public string Cidade { get; set; }
        /// <example>
        /// SC
        /// </example>
        public string Uf { get; set; }
        /// <example>
        /// 1
        /// </example>
        public int Clienteid { get; set; }
        /// <example>
        /// 1
        /// </example>
        public int Status { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatoTelecom
{
    class Linha
    {
        private string _id;
        private string _idCliente;
        private string _idPlano;
        private Cliente _cliente;
        private Plano _plano;
        private string _numero;
        private string _contratacao;
        private string _mensalidade;
        private bool _ativa;

        public string Id { get => _id; set => _id = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
        public Plano Plano { get => _plano; set => _plano = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Contratacao { get => _contratacao; set => _contratacao = value; }
        public string Mensalidade { get => _mensalidade; set => _mensalidade = value; }
        public bool Ativa { get => _ativa; set => _ativa = value; }
        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public string IdPlano { get => _idPlano; set => _idPlano = value; }

        public Linha(Cliente cliente, Plano plano, string numero, DateTime contratacao, string mensalidade, bool ativa)
        {
            Cliente = cliente;
            IdCliente = cliente.Id;
            Plano = plano;
            IdPlano = plano.Id;
            Numero = numero;
            Contratacao = $"{contratacao.Day}/{contratacao.Month}/{contratacao.Year}";
            Mensalidade = mensalidade;
            Ativa = ativa;
        }
    }
}

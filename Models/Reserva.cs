namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            bool capacidadeSuite = hospedes.Count() <= Suite.Capacidade;
            // *IMPLEMENTADO*
            if (capacidadeSuite)
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO*
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO*
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO*
            decimal valor = DiasReservados * Suite.ValorDiaria;
            
            bool temDesconto = DiasReservados >= 10;
            // // *IMPLEMENTADO*
            if (temDesconto)
            {
                valor = valor - (valor * 0.1M);
            }

            return valor;
        }
    }
}
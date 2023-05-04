namespace EscopoAutomacao
{
    public class ConstrutorDeFrase
    {
        public string[] Usuarios = new string[]
        {
            "Erick",
            "Victor",
            "Raphael",
            "Matheus"
        };

        public (int, string, string)[] Pedidos = new (int, string, string)[]
        {
            (1, "Erick", "Geladeira"),
            (2, "Erick", "Smartphone"),
            (3, "Erick", "Máquina de Lavar"),
            (1, "Victor", "Lancha"),
            (2, "Victor", "Mansão"),
            (1, "Raphael", "Playstation 7"),
            (2, "Raphael", "PC Gamer"),
            (3, "Raphael", "TV OLED"),
            (4, "Raphael", "Ar Condicionado"),
        };

        public string ConstruirFrase(string usuario)
        {
            // Criar uma classe nova
            // Dividir essas operações de criação da fraseologia em grupos
            // Cada grupo vai virar um método
            // Nesse método ConstruirFrase você chame os métodos que foram criados
            /*
             * No fim o formato 
             * 
             * var minhaClasse = new MinhaClasse()
             * 
             * var frase = minhaClasse.ObterFraseInicial();
             * 
             * frase += = minhaClasse.ObterUsuarioCadastrado();
             * 
             * frase += minhaClasse.ObterPedidos();
             * 
             * ...
             * 
             */

            var frase = $"Bem vindo ao bot!";
            
            var usuarioCadastrado = Usuarios.FirstOrDefault(x => x == usuario);
            if (usuarioCadastrado == null)
                return frase += "\nHmm... Não encontrei esse usuário";

            frase += $"\n{usuarioCadastrado}, vou buscar seus pedidos pra você!";

            var pedidosCadastrados = Pedidos.Where(x => x.Item2 == usuarioCadastrado).ToList();
            
            if(pedidosCadastrados.Count() > 0)
            {
                foreach (var pedidoCadastrado in pedidosCadastrados)
                {
                    frase += $"\n{pedidoCadastrado.Item1} - {pedidoCadastrado.Item3}";
                }
            } 
            else
            {
                frase += "\nHmmm... Vi aqui que você não tem nenhum pedido";
            }

            frase += "\nConsigo te ajudar com algo mais?";

            return frase;
            
        }
    }
}

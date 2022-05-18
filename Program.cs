using System;

namespace DioSeries
{
    class Program
    {
        static CliRepositorio repositorio = new CliRepositorio();
        static void Main(string[] args)
        {

            string OpcaoUser = ObterOpcaoUser();

            while (OpcaoUser.ToUpper() != "X")
            {
                switch(OpcaoUser)
                {
                case "1":
                    ListarCliente();
                    break;
                case "2":
                    InserirCliente();
                    break;;
                case "3":
                    VizualizarCliente();
                    break;
                case "C":
                    Console.Clear();
                    break;
                default:
                    throw new Exception("Insira Alguma opção!");
                }
                OpcaoUser = ObterOpcaoUser();
            }
            
        }

        public static void InserirCliente()
        {
            Console.Write("Digite o seu Nome: ");
            string entNome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");
            string entCPF = Console.ReadLine();

            Console.Write("A sua data de Nascimento: ");
            int entdtn = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da sua mãe: ");
            string entmae = Console.ReadLine();

            Console.Write("Digite o seu endereço: ");
            string entend = Console.ReadLine();

            Cliente novoCliente = new Cliente(id: repositorio.ProximoId(),
                nome: entNome,      
                cpf: entCPF,
                dtn: entdtn,
                mae: entmae,
                end: entend);
        repositorio.Insere(novoCliente);
        }

        public static void ListarCliente()
        {
            Console.WriteLine("Listar Clientes");

            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum Cliente Cadastrado");
                return;
            }

        }

        public static void VizualizarCliente()
        {
            Console.WriteLine("Digite o id do cliente: ");
            int indiceCliente = int.Parse(Console.ReadLine());

            var cliente = repositorio.RetornaPorId(indiceCliente);
            Console.WriteLine(cliente);
        }

        public static string ObterOpcaoUser()
        {
            Console.WriteLine();
             Console.WriteLine("Olá, Bem-vindos!!");
              Console.WriteLine("Informe a opção desejada: ");
               Console.WriteLine("1 - Listar Clientes!");
                Console.WriteLine("2 - Inserir novos Clientes!");
                   Console.WriteLine("3 - Vizulizar Clientes!");
                    Console.WriteLine("C- Limpar a tela.");
                     Console.WriteLine("X- Sair.");
                      Console.WriteLine();

            string OpcaoUser = Console.ReadLine().ToUpper();
            Console.WriteLine();      
            return OpcaoUser;
        }
    }
}

using System.ComponentModel.DataAnnotations;

internal class GerirFuncionarios
{

   static List<string> NomeFuncionario = new List<string>();
   static List<int> CodFuncionario = new List<int>();
    static List<int> TelefoneFuncionario = new List<int>();
    static List<string> EmailFuncionario = new List<string>();

    private static void Main(string[] args)
    {
        Menu();

        static void Menu()
        {

            bool sair = false;
            int opcao = 0;

            while (sair == false)
            {
                Console.Clear();
                Console.WriteLine("Bem vindo á nossa aplicação de Gerenciamento de Funcionários! \n Que operação pretende realizar?");
                Console.WriteLine("Adicionar Funcionário (1)");
                Console.WriteLine("Alterar Funcionário (2)");
                Console.WriteLine("Mostrar Funcionário (3)");
                Console.WriteLine("Listar Funcionários (4)");
                Console.WriteLine("Sair da Aplicação (0)");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        AddFuncionario();
                        break;
                    case 2:
                        AlterarFuncionarios();
                        break;
                    case 3:
                        MostrarFuncionarios();
                        break;
                    case 4:
                        break;
                    case 0:
                        sair = true;
                        break;
                    default:
                        break;
                }

            }
        }

        static void AddFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Qual o Nome do Funcionário");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira o Telefone do Funcionário");
        int Telefone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o E-mail do Funcionário");
            string email = Console.ReadLine();

            int NovoCod = CodFuncionario.Count() + 1;

            CodFuncionario.Add(NovoCod);
            NomeFuncionario.Add(nome);
            EmailFuncionario.Add(email);
            TelefoneFuncionario.Add(Telefone);

            Console.WriteLine("O Funcionário " + nome + " foi inserido no sistema com sucesso! \n Bem-Vindo!");
            Console.WriteLine("O que pretende fazer agora: \n Voltar ao Menu Inicial(1) \n Sair da Aplicação(2)");
            int opcao = 0;
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Menu();
                    break;

                    case 2:
                    break;
            }
        }

        static void AlterarFuncionarios()
        {
            
        }

        static void MostrarFuncionarios()
        {
            Console.WriteLine(NomeFuncionario);
            Console.WriteLine(CodFuncionario);
            Console.WriteLine(TelefoneFuncionario);
            Console.WriteLine(EmailFuncionario);
        }
    }
    
}
using Projeto_extensao;
using System.ComponentModel.Design;
using static Projeto_extensao.Servicio;


var opcao = 0;
var opcao2 = 0;
do
{
    Console.Clear();
    ExibirMenu();
    var input = Console.ReadLine();
    if(int.TryParse(input, out opcao)) {
        switch (opcao)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Ensira o nome do Paciente:");
                string nome = Console.ReadLine();
                MenudeServiço();
                var input2 = Console.ReadLine();
                int servicio;
                if (int.TryParse(input2, out servicio))
                {


                    Servicio NovoServicio = new Servicio();
                    if (servicio == 1)
                    {
                        NovoServicio = new Servicio(Servicio.TipoServicio.Medico);
                    }
                    else
                    {
                        if (servicio == 2)
                        {
                            NovoServicio = new Servicio(Servicio.TipoServicio.Enfermeiro);
                        }
                        else
                        {
                            if (servicio == 3)
                            {
                                NovoServicio = new Servicio(Servicio.TipoServicio.Dentista);
                            }
                            else
                            {
                                if (servicio == 4)
                                {
                                    NovoServicio = new Servicio(Servicio.TipoServicio.Psicologo);
                                }
                            }
                        }
                    }
                    Paciente NovoPaciente = new Paciente(nome, NovoServicio);
                    ListaPacientes.AdicionarPaciente(NovoPaciente);
                    ListaPacientes.AdicionaraTodosOsPacientesDoDia(NovoPaciente);
                    Console.WriteLine("Paciente cadastrado com sucesso!");
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    OpcaoInvalida();
                }
                break;

            case 2:
                Console.Clear();
                ExibirHorarios();
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Deseja filtrar o próximo paciente da fila de qual serviço?");
                MenudeServiço();
                var input3 = Console.ReadLine();
                string nomeDoPaciente = "Default";
                int tipoServicoSelecionado;
                if (int.TryParse(input3, out tipoServicoSelecionado))
                {
                    if (tipoServicoSelecionado == 1)
                    {
                        nomeDoPaciente = ListaPacientes.PrimeiroPacientePorTipo(Servicio.TipoServicio.Medico);
                        ListaPacientes.RemoverPrimeiroPaciente(Servicio.TipoServicio.Medico);


                    }
                    else
                    {
                        if (tipoServicoSelecionado == 2)
                        {
                            nomeDoPaciente = ListaPacientes.PrimeiroPacientePorTipo(Servicio.TipoServicio.Enfermeiro);
                            ListaPacientes.RemoverPrimeiroPaciente(Servicio.TipoServicio.Enfermeiro);
                        }
                        else
                        {
                            if (tipoServicoSelecionado == 3)
                            {
                                nomeDoPaciente = ListaPacientes.PrimeiroPacientePorTipo(Servicio.TipoServicio.Dentista);
                                ListaPacientes.RemoverPrimeiroPaciente(Servicio.TipoServicio.Dentista);
                            }
                            else
                            {
                                if (tipoServicoSelecionado == 4)
                                {
                                    nomeDoPaciente = ListaPacientes.PrimeiroPacientePorTipo(Servicio.TipoServicio.Psicologo);
                                    ListaPacientes.RemoverPrimeiroPaciente(Servicio.TipoServicio.Psicologo);
                                }
                            }
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("Próximo Paciente a ser atendido: ");
                    Console.WriteLine(nomeDoPaciente);
                    Console.WriteLine("Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                }
                else
                {
                    OpcaoInvalida();
                }
                break;

            case 4:
                Console.Clear();
                ListaPacientes.MostrarTodosPacientesDoDia();
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                break;

            case 5:
                Console.Clear();
                Console.WriteLine("Deseja mesmo encerrar o programa? Y - Sim N - Não");
                var opcao3 = Console.ReadLine();
                if (opcao3 == "Y")
                {
                    ListaPacientes.RemoverTodosPacienteListaDoDia();
                    Console.WriteLine("Encerrando o programa de fila.");
                    opcao2 = 1;
                }
                break;

            default:
                Console.Clear();
                Console.WriteLine("Opção Inválida");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                break;
        }
    }
    else
    {
        OpcaoInvalida();
    }
}
while (opcao2 == 0);

Console.ReadKey();

static void ExibirMenu()
{
    Console.WriteLine("1 - Cadastrar paciente na fila.");
    Console.WriteLine("2 - Conferir o horário dos serviços.");
    Console.WriteLine("3 - Exibir o próximo na fila");
    Console.WriteLine("4 - Mostrar todos os pacientes do dia");
    Console.WriteLine("5 - Encerrar e Deletar a fila");
}
static void MenudeServiço()
{
    Console.WriteLine("Selecione o Tipo de Serviço");
    Console.WriteLine("1 = Médico");
    Console.WriteLine("2 = Enfermeiro");
    Console.WriteLine("3 = Dentista");
    Console.WriteLine("4 = Psicólogo");
}

static void OpcaoInvalida()
{
    Console.Clear();
    Console.WriteLine("Ensira um número válido!");
    Console.WriteLine("Pressione qualquer tecla para continuar.");
    Console.ReadKey();
}

static void ExibirHorarios()
{
    Console.WriteLine("Nédico: 07:30–12:00, 13:30–17:00");
    Console.WriteLine("Enfermeiro: 07:30–12:00, 13:30–17:00");
    Console.WriteLine("Dentista: 07:30–12:00, 13:30–17:00");
    Console.WriteLine("Psícólogo: 07:30–12:00, 13:30–17:00");
}
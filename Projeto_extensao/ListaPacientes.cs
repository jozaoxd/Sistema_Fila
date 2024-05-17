using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_extensao
{
    internal class ListaPacientes
    {
        public static List<Paciente> pacientes = new List<Paciente>();
        public static List<Paciente> pacientesDoDia = new List<Paciente>();

        public static void AdicionarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
        public static void AdicionaraTodosOsPacientesDoDia(Paciente paciente)
        {
            pacientesDoDia.Add(paciente);
        }
        public static void MostrarPacientes()
        {
            Console.WriteLine("Lista de Pacientes:");
            foreach(Paciente paciente in pacientes)
            {
                Console.WriteLine($"Nome: {paciente.Nome}");
            }
        }
        public static void MostrarTodosPacientesDoDia()
        {
            Console.WriteLine($"Lista de Todos os Pacientes do Dia(Quantidade: {pacientesDoDia.Count})");
            foreach(Paciente paciente in pacientesDoDia)
            {
                Console.WriteLine(paciente.Nome);
            }
        }

        public static string PrimeiroPacientePorTipo(Servicio.TipoServicio servicio)
        {
            Paciente proximopaciente = pacientes.FirstOrDefault(p => p.Servicio.Tipo == servicio);
            if (proximopaciente != null)
            {
                return proximopaciente.Nome;
            }
            else
            {
                return "Não há próximo paciente";
            }
        }
        public static void RemoverPrimeiroPaciente(Servicio.TipoServicio servicio)
        {
            Paciente PacienteSelecionado = pacientes.FirstOrDefault(p => p.Servicio.Tipo == servicio);
            if(PacienteSelecionado != null)
            {
                pacientes.Remove(PacienteSelecionado);
            }
        }
        public static void RemoverTodosPacienteListaDoDia()
        {
            Paciente paciente = new Paciente();
            pacientesDoDia.RemoveAll(p => p == paciente);
        }

    }
}

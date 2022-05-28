using JovemProgramador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Data.Repositorio.Interfaces
{
    public interface IAlunoRepositorio 
    {
        AlunoModel Inserir(AlunoModel aluno);

        List<AlunoModel> BuscarAluno();

        AlunoModel BuscarId(int id);

        bool Atualizar(AlunoModel aluno);

        bool Excluir(int id);

        List<AlunoModel> FiltroIdade(int idade, string operacao);
        List<AlunoModel> FiltroNome(string nome);
        List<AlunoModel> FiltroContato(string contato);
        object BuscarId(object id);
        EnderecoModel InserirEndereco(EnderecoModel endereco);
    }
}

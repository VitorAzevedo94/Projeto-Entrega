using Controle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle.Repositorio
{
    public interface ICadastroRepositorio
    {
        CadastroModel ListarPorID(int id);
        List<CadastroModel> BuscarTodos();
        CadastroModel Adicionar(CadastroModel cadastro);
        CadastroModel Atualizar(CadastroModel cadastro);
        bool Apagar(int id);

    }
}

using Controle.Data;
using Controle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
    
    namespace Controle.Repositorio
{
    public class CadastroRepositorio : ICadastroRepositorio
    {
        private readonly BancoContext _bancoContext;
        private readonly object _context;

        public CadastroRepositorio(BancoContext BancoContext)
        {
            _bancoContext = BancoContext;
        }
        public CadastroModel Adicionar(CadastroModel cadastro)
        {
            // Gravar no banco de dados local

            _bancoContext.Cadastro.Add(cadastro);
            _bancoContext.SaveChanges();
            return cadastro;
        }



        public CadastroModel Atualizar(CadastroModel cadastro)
        {
            CadastroModel cadastroDB = ListarPorID(cadastro.Id);
                if (cadastroDB == null) throw new Exception("Houve um erro na atualização do cadastro");

                        cadastroDB.Login = cadastro.Login;
                        cadastroDB.Name = cadastro.Name;
                        cadastroDB.Perfil = cadastro.Perfil;

                 _context.Cad.Update(cadastroDB)
                 _context.SaveChanges();
            return cadastroDB;


        }

        public List<CadastroModel> BuscarTodos()
        {
            return _bancoContext.Cadastro.ToList(); 

        }

        public CadastroModel ListarPorID(int id)
        {
           return _context.Cadastro.FirstOrDefault(x => x.Id == id );


        }
        public bool Apagar(int id)
        {
            CadastroModel cadastroDB = ListarPorID(cadastro.Id);
                if (cadastroDB == null) throw new Exception("Houve um erro na Exclusão do Cadastro");

            _context.Cad.Remove(cadastroDB);
            _context.SaveChanges();

            return true;
        }
    }
}

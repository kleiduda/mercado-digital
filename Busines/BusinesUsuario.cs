﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using Supporte.Enums;
using Supporte.Cache;

namespace Busines
{
   public class BusinesUsuario
    {
        DadosUsuario obj = new DadosUsuario();
        //listando funcoes de usuario
        public static DataTable ListarFuncoes()
        {
            return new DadosUsuario().ListFuncao();
        }
        public bool FuncaoUsuario(int idFuncao, string nomeFuncao)
        {
            return obj.FuncaoUsuario(idFuncao, nomeFuncao);
        }
        //listando usuarios
        public bool LoginUser(string user, string password)
        {
            return obj.LoginUsuario(user, password);
        }
        //verificando se usuario ja esta no banco
        public static bool ValidaUsuario(string login)
        {
            DadosUsuario obj = new DadosUsuario();
            obj.Login = login;
            return obj.Validate(obj);
        }
        //cadastro de usuario
        public static string InsertUsuario(string login, string nome, string sobreNome, string email, string telefone, int cargo, string senha, string foto)
        {
            DadosUsuario obj = new DadosUsuario();
            obj.Login = login;
            obj.Nome = nome;
            obj.SobreNome = sobreNome;
            obj.Email = email;
            obj.Telefone = telefone;
            obj.Cargo = cargo;
            obj.Senha = senha;
            obj.Foto = foto;
            return obj.InsertUsuario(obj);
        }
        //atualizando cadastro ususario
        public static string Update(int idUsuario, string login, string nome, string sobreNome, string email, string telefone, int cargo, string senha, string foto)
        {
            DadosUsuario obj = new DadosUsuario();
            obj.IdVendedor = idUsuario;
            obj.Login = login;
            obj.Nome = nome;
            obj.SobreNome = sobreNome;
            obj.Email = email;
            obj.Telefone = telefone;
            obj.Cargo = cargo;
            obj.Senha = senha;
            obj.Foto = foto;
            return obj.Edit(obj);
        }
        //listandoo usuarios
        public static DataTable ListarUsuarios()
        {
            return new DadosUsuario().ListarUsuarios();
        }
        
        //public static List<DadosUsuario> ListDados()
        //{
        //    List<DadosUsuario> lista = new List<DadosUsuario>();
        //    DadosUsuario obj = new DadosUsuario();
        //    lista.Add(obj.IdVendedor);
        //    return obj.ListVendedorWithLista();
        //}
    }
}

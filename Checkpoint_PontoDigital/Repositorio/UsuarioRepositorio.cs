using System;
using System.Collections.Generic;
using System.IO;
using Checkpoint_PontoDigital.Models;

namespace Checkpoint_PontoDigital.Repositorio
{
    public class UsuarioRepositorio :BaseRepository
    {
       public static uint CONT = 0;
        private const string PATH = "Database/usuario.csv";
        private const string PATH_INDEX = "Database/usuario_Id.csv";
        private List<UsuarioModel> usuarios = new List<UsuarioModel> ();

        public UsuarioRepositorio()
        {
            if (!File.Exists(PATH_INDEX)){
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir (UsuarioModel usuario) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (usuario);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar (UsuarioModel usuario) {
            var usuariosRecuperados = ObterRegistrosCSV (PATH);
            var usuarioString = PrepararRegistroCSV (usuario);
            var linhausuario = -1;
            var resultado = false;

            for (int i = 0; i < usuariosRecuperados.Length; i++) {
                if (usuarioString.Equals (usuariosRecuperados[i])) {
                    linhausuario = i;
                    resultado = true;
                }
            }
            if (linhausuario >= 0) {
                usuariosRecuperados[linhausuario] = usuarioString;
                File.WriteAllLines (PATH, usuariosRecuperados);
            }

            return resultado;

        }

        public bool Apagar (ulong id) {

            var usuariosRecuperados = ObterRegistrosCSV (PATH);
            var linhausuario = -1;
            var resultado = false;

            for (int i = 0; i < usuariosRecuperados.Length; i++) {
                if (id.Equals (usuariosRecuperados[i])) {
                    linhausuario = i;
                    resultado = true;
                }
            }

            if (linhausuario >= 0) {
                usuariosRecuperados[linhausuario] = "";
                try {
                    File.WriteAllLines (PATH, usuariosRecuperados);

                } catch(DirectoryNotFoundException dnfe) {
                    System.Console.WriteLine("Diretório não encontrado. Favor verificar.");
                } catch (PathTooLongException ptle) {
                    System.Console.WriteLine("Nome do arquivo é muito grande.");
                }
            }

            return resultado;
        }

        public UsuarioModel ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString(), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public UsuarioModel ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (email.Equals (ExtrairCampo (email, item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }
        // public UsuarioModel ObterPor(string nome){
        //     foreach (var item in ObterRegistrosCSV(PATH))
        //     {
        //         if (nome.Equals(ExtrairCampo(nome,item)))
        //         {
        //             return ConverterEmObjeto(item);
        //         }
        //     }
        //     return null;
        // }

        public List<UsuarioModel> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                UsuarioModel usuario = ConverterEmObjeto (item);

                this.usuarios.Add (usuario);
            }
            return this.usuarios;
        }

        private UsuarioModel ConverterEmObjeto (string registro) {

            UsuarioModel usuario = new UsuarioModel();
            System.Console.WriteLine("REGISTRO:" + registro);
            usuario.Id = int.Parse(ExtrairCampo("id", registro));
            usuario.Nome = ExtrairCampo("nome", registro);
            usuario.Email = ExtrairCampo("email", registro);
            usuario.Senha = ExtrairCampo("senha", registro);
            usuario.Telefone = ExtrairCampo("telefone", registro);
            usuario.DataNascimento = DateTime.Parse(ExtrairCampo("data_nascimento", registro));

            return usuario;
        }

        private string PrepararRegistroCSV (UsuarioModel usuario) {
            return $"id={CONT};nome={usuario.Nome};email={usuario.Email};senha={usuario.Senha};telefone={usuario.Telefone};data_nascimento={usuario.DataNascimento};\n";
        }
    }
}
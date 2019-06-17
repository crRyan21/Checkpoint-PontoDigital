using System;
using System.Collections.Generic;
using System.IO;
using Checkpoint_PontoDigital.Models;

namespace Checkpoint_PontoDigital.Repositorio {
    public class DepoimentoRepositorio : BaseRepository {
        public static uint CONT = 0;
        private const string PATH = "Database/Dep.csv";
        private const string PATH_INDEX = "Database/Dep_Id.csv";
        private List<DepoimentoModel> usuarios = new List<DepoimentoModel> ();

        public DepoimentoRepositorio () {
            if (!File.Exists (PATH_INDEX)) {
                File.Create (PATH_INDEX).Close ();
            }

            var ultimoIndice = File.ReadAllText (PATH_INDEX);
            uint indice = 0;
            uint.TryParse (ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir (DepoimentoModel usuario) {
            CONT++;
            File.WriteAllText (PATH_INDEX, CONT.ToString ());
            string linha = PrepararRegistroCSV (usuario);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar (DepoimentoModel usuario) {
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
        public bool Apagar (int id) {

            var usuariosRecuperados = ObterRegistrosCSV (PATH);
            var linhausuario = -1;
            var resultado = false;

            for (int i = 0; i < usuariosRecuperados.Length; i++) {
                if (!string.IsNullOrEmpty (usuariosRecuperados[i])) {
                    var obj = ConverterEmObjeto (usuariosRecuperados[i]);
                    if (id.Equals (obj.Id)) {
                        linhausuario = i;
                        resultado = true;
                    }
                }
            }
            if (linhausuario >= 0) {
                usuariosRecuperados[linhausuario] = null;
                // for (int x = linhausuario; x <= usuariosRecuperados.Length; x--)
                // {
                //     usuariosRecuperados[linhausuario] = usuariosRecuperados[x];
                // }
                try {

                    File.WriteAllLines (PATH, usuariosRecuperados);

                } catch (DirectoryNotFoundException dnfe) {
                    System.Console.WriteLine ("Diretório não encontrado. Favor verificar.");
                } catch (PathTooLongException ptle) {
                    System.Console.WriteLine ("Nome do arquivo é muito grande.");
                }
            }
            return resultado;
        }
        public DepoimentoModel ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString (), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }
        public DepoimentoModel ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (email.Equals (ExtrairCampo (email, item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }
        // public DepoimentoModel ObterPor(string nome){
        //     foreach (var item in ObterRegistrosCSV(PATH))
        //     {
        //         if (nome.Equals(ExtrairCampo(nome,item)))
        //         {
        //             return ConverterEmObjeto(item);
        //         }
        //     }
        //     return null;
        // }

        public List<DepoimentoModel> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    continue;
                }
                DepoimentoModel usuario = ConverterEmObjeto (item);
                this.usuarios.Add (usuario);
            }
            return this.usuarios;
        }
        private DepoimentoModel ConverterEmObjeto (string registro) {

            DepoimentoModel usuario = new DepoimentoModel ();
            System.Console.WriteLine ("REGISTRO:" + registro);
            usuario.Id = int.Parse (ExtrairCampo ("id", registro));
            usuario.Nome = ExtrairCampo ("nome", registro);
            usuario.Email = ExtrairCampo ("email", registro);
            usuario.Telefone = ExtrairCampo ("telefone", registro);
            usuario.Titulo = ExtrairCampo ("titulo", registro);
            usuario.Descricao = ExtrairCampo ("descricao", registro);
            usuario.Estado = ExtrairCampo ("estado", registro);
            return usuario;
        }

        private string PrepararRegistroCSV (DepoimentoModel usuario) {
            return $"id={CONT};nome={usuario.Nome};titulo={usuario.Titulo};descricao={usuario.Descricao};estado={usuario.Estado}\n";
        }

        public void Excluir (ulong id) {
            string[] linhas = File.ReadAllLines (PATH);
            for (int i = 0; i < linhas.Length; i++) {
                string[] linha = linhas[i].Split (";");
                if (id.ToString () == linha[0]) {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines (PATH, linhas);
        }
    }
}
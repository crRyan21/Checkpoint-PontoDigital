using System;
using System.Collections.Generic;
using System.IO;
using Checkpoint_PontoDigital.Models;

namespace Checkpoint_PontoDigital.Repositorio
{
    public class AdmRepositorio :BaseRepository
    {
         public static uint CONT = 0;
        private const string PATH = "Database/Administrador.csv";
        private const string PATH_INDEX = "Database/Adm_Id.csv";
        private List<AdmModel> administradores = new List<AdmModel> ();

        public AdmRepositorio()
        {
            if (!File.Exists(PATH_INDEX)){
                File.Create(PATH_INDEX).Close();
            }

            var ultimoIndice = File.ReadAllText(PATH_INDEX);
            uint indice = 0;
            uint.TryParse(ultimoIndice, out indice);
            CONT = indice;
        }

        public bool Inserir (AdmModel administrador) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (administrador);
            File.AppendAllText (PATH, linha);

            return true;
        }

        public bool Atualizar (AdmModel administrador) {
            var clientesRecuperados = ObterRegistrosCSV (PATH);
            var clienteString = PrepararRegistroCSV (administrador);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++) {
                if (clienteString.Equals (clientesRecuperados[i])) {
                    linhaCliente = i;
                    resultado = true;
                }
            }
            if (linhaCliente >= 0) {
                clientesRecuperados[linhaCliente] = clienteString;
                File.WriteAllLines (PATH, clientesRecuperados);
            }
            return resultado;
        }

        public bool Apagar (ulong id) {

            var clientesRecuperados = ObterRegistrosCSV (PATH);
            var linhaCliente = -1;
            var resultado = false;

            for (int i = 0; i < clientesRecuperados.Length; i++) {
                if (id.Equals (clientesRecuperados[i])) {
                    linhaCliente = i;
                    resultado = true;
                }
            }

            if (linhaCliente >= 0) {
                clientesRecuperados[linhaCliente] = "";
                try {
                    File.WriteAllLines (PATH, clientesRecuperados);

                } catch(DirectoryNotFoundException dnfe) {
                    System.Console.WriteLine("Diretório não encontrado. Favor verificar.");
                } catch (PathTooLongException ptle) {
                    System.Console.WriteLine("Nome do arquivo é muito grande.");
                }
            }

            return resultado;
        }

        public AdmModel ObterPor (ulong id) {

            foreach (var item in ObterRegistrosCSV (PATH)) {
                if (id.Equals (ExtrairCampo (id.ToString(), item))) {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public AdmModel ObterPor (string email) {

            foreach (var item in ObterRegistrosCSV (PATH)) 
            {
                if (email.Equals (ExtrairCampo (email, item))) 
                {
                    return ConverterEmObjeto (item);
                }
            }
            return null;
        }

        public List<AdmModel> ListarTodos () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                AdmModel administrador = ConverterEmObjeto (item);

                this.administradores.Add (administrador);
            }
            return this.administradores;
        }

        private AdmModel ConverterEmObjeto (string registro) {

            AdmModel administrador = new AdmModel();
            System.Console.WriteLine("REGISTRO:" + registro);
            administrador.Id = int.Parse(ExtrairCampo("id", registro));
            administrador.Nome = ExtrairCampo("nome", registro);
            administrador.Email = ExtrairCampo("email", registro);
            administrador.Senha = ExtrairCampo("senha", registro);
            administrador.Telefone = ExtrairCampo("telefone", registro);
            administrador.DataNascimento = DateTime.Parse(ExtrairCampo("data_nascimento", registro));

            return administrador;
        }

        private string PrepararRegistroCSV (AdmModel administrador) {
            return $"id={CONT};nome={administrador.Nome};email={administrador.Email};senha={administrador.Senha};telefone={administrador.Telefone};data_nascimento={administrador.DataNascimento};\n";
        }

    }
}
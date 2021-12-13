using E_JOGOSS.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOSS.Models
{
    //Heranca -> EjogosBase
    public class Equipe : EjogosBase,IEquipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        private const string path = "Database/equipe.csv";

        //construtor da classe(ctor)
        public Equipe()
        {
            CreateFolderAndFile(path);
        }

        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }

        public void Create(Equipe nova_equipe)
        {
            //recebe um objeto do tipo equipe
            string[] linha = { Prepare(nova_equipe) };
            File.AppendAllLines(path, linha);
        }

        public void Delete(int idEquipe)
        {
            throw new NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(path);

            foreach (string item in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(item.Split(';')[0]);
                equipe.Nome = item.Split(';')[1];
                equipe.Imagem = item.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}

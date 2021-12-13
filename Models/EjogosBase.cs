using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_JOGOSS.Models
{
    public class EjogosBase
    {
        //funcao pra criar a pasta e o arquivo
        public void CreateFolderAndFile(string path)
        {
            //formato: pasta/arquivo.csv
            string folder = path.Split('/')[0]; //pasta
            string file = path.Split('/')[1];  //arquivo

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!File.Exists(file))
            {
                File.Create(path);
            }
        }
    }
}

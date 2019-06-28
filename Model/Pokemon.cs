using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pokemon
    {
        public int Id;
        public int IdCategoria;

        public Categoria categoria;

        public string Nome;

        public Categoria Categoria { get; set; }
    }
}

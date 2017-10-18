using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relacionamento.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public IList<Post> Posts { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Relacionamento.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<Tag>().ToList();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
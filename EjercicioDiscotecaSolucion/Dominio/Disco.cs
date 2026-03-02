using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        public int Id { get; set; }
        public string TitleAlbum { get; set; }
        public DateTime LaunchDate { get; set; }
        public int Songs { get; set; }
        public string UrlCover { get; set; }
        public Estilo Style { get; set; }
        public Edicion Edition { get; set; }
        
    }
}

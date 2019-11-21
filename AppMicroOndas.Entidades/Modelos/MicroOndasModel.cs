using AppMicroOndas.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Entidades.Modelos
{
    public class MicroOndasModel : BaseModel
    {
        public string Prato { get; set; }
        public bool EhArquivo => Prato.Contains(":\\");
        public StatusEnum Status { get; set; }

    }
}

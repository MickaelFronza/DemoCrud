using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCRUD.ViewModels
{
    public class ParametrosPaginacao
    {
        public string SearchPhrase { get; set; }

        public string CampoOrdenado { get; set; }

        public int Current { get; set; }
        public int RowCount { get; set; }
    }
}
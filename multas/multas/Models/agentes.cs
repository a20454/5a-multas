﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multas.Models
{
    public class agentes
    {
        //id, nome, esquadra, foto
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Esquadra { get; set; }
        public string Foto { get; set; }
    }
}
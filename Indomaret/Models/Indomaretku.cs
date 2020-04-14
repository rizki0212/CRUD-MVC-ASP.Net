using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Indomaret.Models
{
    public class Indomaretku
    {
        [Key]
        public string kode_barang { get; set; }

        public string nama { get; set; }

        public int harga { get; set; }

        public string suplier { get; set; }
    }
}
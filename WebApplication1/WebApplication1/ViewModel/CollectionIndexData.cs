using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class CollectionIndexData
    {
        public IEnumerable<Collection> Collections { get; set; }

        public IEnumerable<List> Lists { get; set; }
    }
}
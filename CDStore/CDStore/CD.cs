﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDStore
{
   public  class CD
    {
        public virtual int CDID { get; set; }
        public virtual string Title{ get; set; }
        public virtual string RecordCompany { get; set; }
        public virtual DateTime Published { get; set; }
        public virtual List <Song> Songs { get; set; }



    }
}

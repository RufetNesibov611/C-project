﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostories.Data
{
     public static class AppDbContext<T>
    {
        public static List<T> Datas;

        static AppDbContext()
        {
            
        }
    }
}

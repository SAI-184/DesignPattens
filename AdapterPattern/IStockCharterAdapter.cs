﻿using AdapterPattern.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public interface IStockCharterAdapter
    {
        void Visualize(Candle stockData);
    }
}

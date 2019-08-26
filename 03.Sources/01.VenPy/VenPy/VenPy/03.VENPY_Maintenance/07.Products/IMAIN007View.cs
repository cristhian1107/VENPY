﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VenPy.Main
{
    public interface IMAIN007LView
    {
        void LViewLoad();
        void Search();
    }
    public interface IMAIN007MView
    {
        MAIN007PView Presenter { get; set; }
        void MViewLoad();
        void CleanControls();
        void SetItem();
        void GetItem();
    }
}


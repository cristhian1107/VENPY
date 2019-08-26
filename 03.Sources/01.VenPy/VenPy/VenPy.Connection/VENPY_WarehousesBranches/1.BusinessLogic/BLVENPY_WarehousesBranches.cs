﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using VenPy.Entities;
using VenPy.Class;
using System.Data;

namespace VenPy.Connection
{
    public partial class BLVENPY_WarehousesBranches : IBLVENPY_WarehousesBranches
    {
        #region [ QUERIES ]

        public ObservableCollection<VENPY_WarehousesBranches> BLWABRS_ByBranch(Int32 p_BUSI_Code, Nullable<Int32> p_BOFF_Code)
        {
            try
            {
                return WABRS_ByBranch(p_BUSI_Code, p_BOFF_Code);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ METHODS ]

        public Boolean BLWABRI_ByBranch(Int32 p_BUSI_Code, Int32 p_BOFF_Code, DataTable p_UDTT_WarehousesBranches, String p_AUDI_CreationUser, Boolean p_Transaction)
        {
            bool l_correcto = false;
            if (p_Transaction)
            {
                DataAccessPersonalSQL.DAP_BeginTransaction();
                try
                {
                    l_correcto = WABRI_ByBranch(p_BUSI_Code, p_BOFF_Code, p_UDTT_WarehousesBranches, p_AUDI_CreationUser);
                    if (l_correcto)
                    { DataAccessPersonalSQL.DAP_CommitTransaction(); }
                    else
                    { DataAccessPersonalSQL.DAP_RollbackTransaction(); }
                    return l_correcto;
                }
                catch (Exception ex)
                {
                    DataAccessPersonalSQL.DAP_RollbackTransaction();
                    throw ex;
                }
            }
            else
            {
                try
                {
                    l_correcto = WABRI_ByBranch(p_BUSI_Code, p_BOFF_Code, p_UDTT_WarehousesBranches, p_AUDI_CreationUser);
                    return l_correcto;
                }
                catch (Exception ex)
                { throw ex; }
            }
        }

        #endregion
    }
}
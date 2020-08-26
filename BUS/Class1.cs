using System;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class DON_HANG_BUS
    {
        public static DataTable Load_DSDH()
        {
            return DON_HANG_DAO.Load_DSDH();
        }
        
    }
}

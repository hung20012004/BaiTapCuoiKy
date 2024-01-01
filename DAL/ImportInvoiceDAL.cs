using DTO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImportInvoiceDAL
    {
        private static SqlConnection conn = DBConfig.Instance.SQLConnect();
        private static ImportInvoiceDAL instance = new();
        public static ImportInvoiceDAL Instance
        {
            get { return instance; }
        }
        public List<ImportInvoice> get()
        {
            List<ImportInvoice> list = new List<ImportInvoice>();
            conn.Open();
            using (var cmd = new SqlCommand("GetImportInvoice", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ImportInvoice importInvoice = new ImportInvoice();
                    importInvoice.ID = reader.GetInt32("id");
                    importInvoice.WarehouseKeeper.ID = reader.GetInt32("warehouseKeeperID");
                    importInvoice.Provider.ID = reader.GetInt32("providerID");
                    importInvoice.ImportDate = reader.GetDateTime("importDate");
                    importInvoice.StatusINT = reader.GetInt32("StatusINT");
                    importInvoice.StatusSTRING = reader.GetString("StatusSTRING");
                    list.Add(importInvoice);
                }
            }
            conn.Close();
            return list;
        }
        public bool insert(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("InsertImportInvoice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@warehouseKeeperID", SqlDbType.Int).Value = importInvoice.WarehouseKeeper.ID;
                    cmd.Parameters.Add("@providerID", SqlDbType.Int).Value = importInvoice.Provider.ID;
                    cmd.Parameters.Add("@importDate", SqlDbType.DateTime).Value = importInvoice.ImportDate;
                    cmd.Parameters.Add("@statusINT", SqlDbType.Int).Value = importInvoice.StatusINT;
                    cmd.Parameters.Add("@statusSTRING", SqlDbType.VarChar).Value = importInvoice.StatusSTRING;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool update(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("UpdateImportInvoice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.Parameters.Add("@warehouseKeeperID", SqlDbType.Int).Value = importInvoice.WarehouseKeeper.ID;
                    cmd.Parameters.Add("@providerID", SqlDbType.Int).Value = importInvoice.Provider.ID;
                    cmd.Parameters.Add("@importDate", SqlDbType.DateTime).Value = importInvoice.ImportDate;
                    cmd.Parameters.Add("@statusINT", SqlDbType.Int).Value = importInvoice.StatusINT;
                    cmd.Parameters.Add("@statusSTRING", SqlDbType.VarChar).Value = importInvoice.StatusSTRING;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool delete(ImportInvoice importInvoice)
        {
            try
            {
                conn.Open();
                using (var cmd = new SqlCommand("DeleteImportInvoice", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool insertDetail(Laptop laptop, ImportInvoice importInvoice)
        {
            try
            {
                using (var cmd = new SqlCommand("InsertInvoiceDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@invoice_id", SqlDbType.Int).Value = importInvoice.ID;
                    cmd.Parameters.Add("@laptop_id", SqlDbType.Int).Value = laptop.ID;
                   // cmd.Parameters.Add("@quantity_import", SqlDbType.Int).Value = laptop.QuantityImport;
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
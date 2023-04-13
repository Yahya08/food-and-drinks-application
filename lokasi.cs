using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Org.BouncyCastle.Utilities.Collections;

namespace LibraryManagementSystem
{
    class GENRE
    {
        MYDB db = new MYDB();

        public Boolean addlokasi(string nama_lokasi, string tanggal)
        {
            string query = "INSERT INTO genres (nama_lokasi, tanggal) VALUES (@nama_lokasi, @tanggal)";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@nama_lokasi", MySqlDbType.Int32);
            parameters[0].Value = nama_lokasi;
            parameters[1] = new MySqlParameter("@tanggal", MySqlDbType.VarChar);
            parameters[1].Value = tanggal;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable lokasiList()
        {
            DataTable table = new DataTable();
            table = db.getData("SELECT* FROM genres", null);

            return table;
        }

    }
}

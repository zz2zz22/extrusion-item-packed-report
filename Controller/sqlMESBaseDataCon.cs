﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace extrusion_item_packed_report
{
    public class sqlMESBaseDataCon
    {

        public MySqlConnection conn = DatabaseUtils.GetMes_Base_DataDBC();

        public string sqlExecuteScalarString(string sql)
        {
            String outstring;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            try
            {
                outstring = cmd.ExecuteScalar().ToString();
                conn.Close();
                return outstring;
            }
            catch (Exception)
            {
                conn.Close();
                return String.Empty;
            }

        }

        public void getComboBoxData(string sql, ref ComboBox cmb)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                cmd.Dispose();
                cmb.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    cmb.Items.Add(row[0].ToString());
                }
            }
            catch (Exception)
            {
            }
            conn.Close();
        }

        public void getComboBoxData(string sql, ref ComboBox cmb, ref ComboBox cmb2)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                adapter.Dispose();
                cmd.Dispose();
                cmb.Items.Clear();
                cmb2.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (cmb.Items != null && cmb.Items.Contains(row[0].ToString()) == false)
                        cmb.Items.Add(row[0].ToString());
                    if (cmb2.Items != null && cmb2.Items.Contains(row[1].ToString()) == false)
                        cmb2.Items.Add(row[1].ToString());
                }
            }
            catch (Exception)
            {
            }
            conn.Close();
        }


        public void sqlDataAdapterFillDatatable(string sql, ref DataTable dt)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                {
                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                }
            }
            catch (Exception)
            {
            }
        }

        public bool sqlExecuteNonQuery(string sql, bool result_message_show)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                int response = cmd.ExecuteNonQuery();
                if (response > 1)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception)
            {
                conn.Close();
                return false;
            }
        }
    }
}

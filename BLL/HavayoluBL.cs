using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HavayoluBL : IDisposable
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cstr"].ConnectionString);

        UcusDbContext ctx = new UcusDbContext();
        public void Dispose()
        {
            ((IDisposable)ctx).Dispose();
        }
        public bool Ekle(Havayolu h)
        {
            ctx.Havayollari.Add(h);
            return ctx.SaveChanges() > 0;
        }
        public bool Sil(Havayolu h)
        {
            Havayolu hh = ctx.Havayollari.Find(h.Id_Havayolu);
            ctx.Havayollari.Remove(hh);
            return ctx.SaveChanges() > 0;
        }
        public bool Guncelle(Havayolu h)
        {
            ctx.Entry<Havayolu>(h).State = EntityState.Modified;
            return ctx.SaveChanges() > 0;
        }
        public DataTable GetDataTable(string cmdtext)
        {
            SqlDataAdapter da = new SqlDataAdapter(cmdtext, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable HavayollariTable() => GetDataTable("spHavayollariListesi");
    }
}

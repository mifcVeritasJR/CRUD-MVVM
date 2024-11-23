using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVVM.Services
{
    public class EmpleadoService
    {
        private readonly SQLiteConnection SQLiteConnection;

        public EmpleadoService()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "");
            //Initiqlize Connection
            SQLiteConnection = new SQLiteConnection(dbPath);
            //Create Table
            SQLiteConnection.CreateTable<Empleado>();
        }

        public List<Empleado> GetAll()
        {
            var res = SQLiteConnection.Table<Empleado>().ToList();
            return res;
        }

        public int Insert(Empleado empleado);
    }
}
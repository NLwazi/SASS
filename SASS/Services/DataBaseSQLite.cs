using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SASS.Models;
using Xamarin.Essentials;
using System.IO;

namespace SASS.Services
{
   public class DataBaseSQLite
    {

        string file_name = "userDb.db";
        public string Url { get; set; }


       public DataBaseSQLite()
        {
            getData();
        }


        void getData()
        {

            Url = Path.Combine(FileSystem.AppDataDirectory, file_name);


        }


    }
}

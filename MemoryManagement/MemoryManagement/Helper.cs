using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryManagement
{
    public class Helper : IDisposable
    {
        SqlConnection sqlConnection = new SqlConnection();
        FileStream fileStream = null;

        public void Save(string fileName, string fileContent)
        {
            using (fileStream = new FileStream(fileName, FileMode.Create))
            {               
                byte[] data = Encoding.ASCII.GetBytes(fileContent);
                fileStream.Write(data, 0, data.Length);
                fileStream.Flush();
                
            }

            
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);


        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Dispose();
                    sqlConnection = null;
                }
                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream = null;
                }
            }
        }



    }
}

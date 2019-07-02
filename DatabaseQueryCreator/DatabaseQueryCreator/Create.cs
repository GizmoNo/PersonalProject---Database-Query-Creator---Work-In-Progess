using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseQueryCreator
{
   public class cboDataSorce
    {
        private static string[] dataTypes = { "varchar", "int" };
        public static string[] DataTypes => dataTypes;
    }
    public class clsCreateTest
    {
        private string TableName { get; set; }
        private string Field1 { get; set; }
        private string Field2 { get; set; }
        private string Field3 { get; set; }
        private string DataType1 { get; set; }
        private string DataType2 { get; set; }
        private string DataType3 { get; set; }

    }
}

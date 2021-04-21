using System;
using System.Collections.Generic;
using System.Text;

namespace Level_6
{
    [Serializable]
    class ArrayDataException : Exception
    {
        int row, column;

        public ArrayDataException(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}

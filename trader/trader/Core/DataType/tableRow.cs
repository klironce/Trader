using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader.Core.DataType
{
    public class tableRow
    {

        public tableColumn[] Header;
        public tableColumn[] Column;
        private int columnCount = 0;
        public int ColumnCount  
        {
            get { return columnCount; }
        }


        public void AddColumn(string HeadName)
        {
            //  Тут будет еще вывод в логи.
            if (columnCount != 0)
            {
                if (CheckName(HeadName))
                    PlusColumn(HeadName);
            }
            else
                    PlusColumn(HeadName);

        }

        private void PlusColumn(string HeadName)
        {
            if (columnCount == 0)
            {
                Header = new tableColumn[1];
                Column = new tableColumn[1];
                Header[0] = new tableColumn();
                Column[0] = new tableColumn();
                Header[0].value.Set(HeadName);
                Header[0].Type = EnumTypes.ColumnType.header;
                Column[0].value.Set(0);
                Column[0].Type = EnumTypes.ColumnType.body;
            }
            else
            {
                tableColumn[] backup = new tableColumn[columnCount*2];
                int i = 0;
                foreach (tableColumn hd in Header)
                {
                    backup[i] = new tableColumn();
                    backup[i].Type = EnumTypes.ColumnType.header;
                    backup[i].value.Set(hd.value.Get());
                    i++;
                }
                foreach (tableColumn cl in Column)
                {
                    backup[i] = new tableColumn();
                    backup[i].Type = EnumTypes.ColumnType.body;
                    backup[i].value.Set(cl.value.Get());
                    i++;
                }
                i = 0;

                Header = new tableColumn[columnCount + 1];
                Column = new tableColumn[columnCount + 1];

                foreach (tableColumn bkup in backup)
                {
                    switch (bkup.Type)
                    {
                        case EnumTypes.ColumnType.header:
                            Header[i] = new tableColumn();
                            Header[i].value.Set(bkup.value.Get());
                            Header[i].Type = EnumTypes.ColumnType.header;
                            break;
                        case EnumTypes.ColumnType.body:
                            Column[i - columnCount] = new tableColumn();
                            Column[i - columnCount].value.Set(bkup.value.Get());
                            Column[i - columnCount].Type = EnumTypes.ColumnType.body;
                            break;
                    }
                    i++;
                }

                Header[columnCount] = new tableColumn();
                Column[columnCount] = new tableColumn();
                Header[columnCount].value.Set(HeadName);
                Header[columnCount].Type = EnumTypes.ColumnType.header;
                Column[columnCount].Type = EnumTypes.ColumnType.header;
                Column[columnCount].value.Set(0);

            }
            columnCount++;
        }

        private bool CheckName(string HeadName)
        {
            foreach (tableColumn tc in Header)
                if (tc.value.Get() == HeadName)
                    return false;
            return true;
        }

        
    }
}
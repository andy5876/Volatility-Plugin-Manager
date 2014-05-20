
///////////////////////////////////////////////////////////////////////////////
/// Volatility Plugin Manager - Excel Writer Module                         ///                      
/// Copyright (C) 2014  Andrew Dove                                         ///
///                                                                         ///
/// This program is free software; you can redistribute it and/or modify    ///
/// it under the terms of the GNU General Public License as published by    ///
/// the Free Software Foundation; either version 2 of the License, or       ///
/// (at your option) any later version.                                     ///
///                                                                         ///
/// This program is distributed in the hope that it will be useful,         ///
/// but WITHOUT ANY WARRANTY; without even the implied warranty of          ///
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the           ///
/// GNU General Public License for more details.                            ///
///                                                                         ///
/// You should have received a copy of the GNU General Public License along ///
/// with this program; if not, write to the Free Software Foundation, Inc., ///
/// 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.             ///
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;

namespace volatility_GUI
{
    class ExcelWriter
    // Class designed to take fixed with text files output from volatility and import them
    // into MS Excel.  A seperate tab will be created in the file for each file and named
    // according to the plugin which created the file.
    {
        int HEADER_LINES = 0;       // Change this value to the number of lines used by the header

        public string FileName;
        public string OutputDir;

        public ExcelWriter(string Directory)
        {
            OutputDir = Directory;
        }

        public void ReadDir(string Directory)
        {
            DirectoryInfo di = new DirectoryInfo(Directory);
            
            Application ExApp = new Application();
            ExApp.Visible = true;
            Workbook wb = ExApp.Workbooks.Add();
            wb.Worksheets.Delete();

            foreach(FileInfo fi in di.EnumerateFiles())
            {
                ReadFile(wb, fi.FullName);
            }
        }

        private void ReadFile(Workbook wb, string FileName)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(FileName);
            string PluginName = fi.Name.Substring(0, fi.Name.Length - 4);
            
            Worksheet ws = wb.Worksheets.Add();
            System.IO.StreamReader file;
            try
            {
                file = new System.IO.StreamReader(FileName);
            }
            catch (Exception e)
            {
                throw e;            // Better error handling required
            }

            for (int i = 0; i < HEADER_LINES;i++ )      // Discard Header Lines
            {
                file.ReadLine();
            }

            string HeaderRow = file.ReadLine();
            string ColSizeRow = file.ReadLine();
            string[] Cols = ColSizeRow.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] ColSizes = new int[Cols.Length];
            for (int i = 0; i < Cols.Length; i++)
                ColSizes[i] = Cols[i].Length +1;
            string[] Headers = MultiSplit(HeaderRow, ColSizes);

            Range c1 = ws.Cells[1, 1];
            Range c2 = ws.Cells[1, Headers.Length];
            Range Row = ws.get_Range(c1, c2);
            Row.Value = Headers;
            Row.Font.Bold = true;

            int y = 2;
            string CurrentLine;
            while ((CurrentLine = file.ReadLine()) != null)
            {
                c1 = ws.Cells[y, 1];
                c2 = ws.Cells[y, Headers.Length];
                Row = ws.get_Range(c1, c2);
                Row.Value = MultiSplit(CurrentLine, ColSizes);
                y++;
            }
            ws.Columns.AutoFit();
            ws.Name = PluginName;
            file.Close();
            file.Dispose();
        }

        private string[] MultiSplit(string s, int[] ColSizes)
        {
            List<String> Cols = new List<String>();
            int pos = 0;
            for(int i = 0; i < ColSizes.Length - 1; i++)
            {
                Cols.Add(s.Substring(pos, ColSizes[i]).TrimEnd());
                pos += ColSizes[i];
            }
            Cols.Add(s.Substring(pos).TrimEnd());       // Read to end of line for last value
            return Cols.ToArray();
        }
    }
}

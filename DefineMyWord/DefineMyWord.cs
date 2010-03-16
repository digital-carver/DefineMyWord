/*
    Copyright (c) 2010 SundaraRaman Ramalingam

    This file is part of DefineMyWord.

    DefineMyWord is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    DefineMyWord is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with DefineMyWord.  If not, see <http://www.gnu.org/licenses/>.
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DefineMyWord
{
    static class DefineMyWord
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BrowserForm());
        }
    }
}

#region LICENSE

// Copyright 2014 LeagueSharp.Loader
// Auth.cs is part of LeagueSharp.Loader.
// 
// LeagueSharp.Loader is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// LeagueSharp.Loader is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with LeagueSharp.Loader. If not, see <http://www.gnu.org/licenses/>.

#endregion

namespace LeagueSharp.Loader.Class
{
    #region

    using System;
    using System.Net.Security;
    using System.Net.Sockets;
    using System.Security.Authentication;
    using System.Text;

    #endregion

    internal static class Auth
    {
        public const string AuthServer = "5.196.9.111";
        public static bool Authed { get; set; }

        public static Tuple<bool, string> Login(string user, string hash)
        {
				return new Tuple<bool, string>(true, "Success!");
		}

        private static string IPB_Clean_Password(string pass)
        {
            pass = pass.Replace("\xC3\x8A", "");
            pass = pass.Replace("&", "&amp;");
            pass = pass.Replace("\\", "&#092;");
            pass = pass.Replace("!", "&#33;");
            pass = pass.Replace("$", "&#036;");
            pass = pass.Replace("\"", "&quot;");
            pass = pass.Replace("\"", "&quot;");
            pass = pass.Replace("<", "&lt;");
            pass = pass.Replace(">", "&gt;");
            pass = pass.Replace("'", "&#39;");

            return pass;
        }

        public static string Hash(string input)
        {
            return Utility.Md5Hash(IPB_Clean_Password(input));
        }
    }
}
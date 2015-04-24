/*
Chroma Visualizer
Copyright (c) 2015 Kevin 'keving' Goeldenitz

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using Microsoft.Win32;

namespace ChromaVisualizer
{
    public class SDKSupport
    {
        public static bool isSDKInstalled()
        {
            string valueName = "Enable";
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Razer Chroma SDK");

            if (registryKey == null)
                return false;

            return (registryKey.GetValue(valueName) == null ? false : true);
        }

        public static void enableSDK()
        {
            string valueName = "Enable";
            string key = @"SOFTWARE\Wow6432Node\Razer Chroma SDK";

            RegistryKey registryKey = Registry.LocalMachine;

            if (registryKey.OpenSubKey(key) == null)
            {
                registryKey.CreateSubKey(key);
            }

            registryKey = registryKey.OpenSubKey(key, true);
            registryKey.SetValue(valueName, (byte)1);
        }
    }
}

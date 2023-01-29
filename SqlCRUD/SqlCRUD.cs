using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SqlCRUD
{
    public class CRUDtool
    {
        public byte[] ImageToByte(System.Drawing.Image imgPhoto)
        {
            MemoryStream mstream = new MemoryStream();
            imgPhoto.Save(mstream, System.Drawing.Imaging.ImageFormat.Bmp);
            byte[] byData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byData, 0, byData.Length);
            mstream.Close();
            return byData;
        }

        public bool RegexAccount(string account)
        {
            if (!Regex.IsMatch(account, "^[a-zA-Z0-9]{6,50}$"))
            {
                return true;
            }
            else { return false; }
        }
        public bool RegexPassword(string password)
        {
            if (!Regex.IsMatch(password, "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{6,12}$"))
            {
                return true;
            }
            else { return false; }
        }
        public bool RegexEmail(string email)
        {
            if (!Regex.IsMatch(email, "^[\\w-]+@[\\w-]+\\.(com|net|org|edu|mil|tv|biz|info)$"))
            {
                return true;
            }
            else { return false; }
        }
    }
}
